Imports Newtonsoft.Json.Linq

Public Class MainFrm
  Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
  'Public Declare Function apiBlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer
  Const KeyDownBit As Integer = &H8000

  Public WithEvents HotKeyTimer As New Timer
  Public WithEvents DurationRepeat As New Timer
  Public WithEvents LongClickTimer As New Timer
  Public WithEvents ClickTimer As New Timer
  Public WithEvents StartTimer As New Timer

  Dim AFK As Boolean = False

  Public timeDelay As Integer = 0
  Public timePress As Integer = 0

  Dim valueRepeat As Integer = 0
  Dim secondRepeat As Integer = 0

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Call First.FirstUsrSettings()

    Dim data As JObject = GetSettings("user.umc")
    initial()
    Dim TypeClicks() As String = {"Single Click", "Double Click", "Press Click"}
    For Each TypeClick As String In TypeClicks
      ComboTypeClick.Items.Add(TypeClick)
    Next

    ComboTypeClick.SelectedIndex = data("type")
    HoldClickOpt()

    HotKeyTimer.Interval = 5
    HotKeyTimer.Enabled = True

    Stats.Show()
  End Sub

  Private Sub ComboTypeClick_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTypeClick.SelectedIndexChanged
    SaveSettings("user.umc", "type", ComboTypeClick.SelectedIndex)
    HoldClickOpt()
  End Sub

  Private Sub RepeatBtn_Click(sender As Object, e As EventArgs) Handles RepeatBtn.Click
    RepeatFrm.ShowDialog()
  End Sub

  Private Sub MousePic_MouseClick(sender As Object, e As MouseEventArgs) Handles MousePic.MouseClick
    If e.Button = Windows.Forms.MouseButtons.Left Then
      ChangeClick()
    End If
  End Sub

  Private Sub DelayBtn_Click(sender As Object, e As EventArgs) Handles DelayBtn.Click
    TimeFrm.form_id = 1
    TimeFrm.ShowDialog()
  End Sub

  Private Sub HoldClickBtn_Click(sender As Object, e As EventArgs) Handles HoldClickBtn.Click
    TimeFrm.form_id = 2
    TimeFrm.ShowDialog()
  End Sub

  'Function Clicker

  Private Sub HotKeyTimer_Tick(sender As Object, e As EventArgs) Handles HotKeyTimer.Tick
    ' Main
    If KeyPressIs({Keys.F11, Keys.ControlKey}) Then
      While GetAsyncKeyState(Keys.F11)
      End While

    ElseIf KeyPressIs({Keys.F11}) Then
      While GetAsyncKeyState(Keys.F11)
      End While

      AutoClicker()
    End If
  End Sub

  Private Sub AutoClicker()
    ComboTypeClick.Enabled = AFK
    RepeatBtn.Enabled = AFK
    DelayBtn.Enabled = AFK
    SettingBtn.Enabled = AFK
    MousePic.Enabled = AFK

    If AFK = False Then
      HoldClickBtn.Enabled = False
      ACactiveClick()
      SettingBtn.Image = My.Resources.disable_settings_8

      Repeat()

      StartTimer.Interval = 500
      StartTimer.Start()

      AFK = True
    Else
      Disabled()
    End If
  End Sub

  Private Sub Repeat()
    Dim settings As JObject = GetSettings("user.umc")
    Select Case CInt(settings("repeat")("type"))
      Case 0
      Case 1
        valueRepeat = CInt(settings("repeat")("value")) - 1
      Case Else
        secondRepeat = IIf(CInt(settings("repeat")("type")) = 2,
                           CInt(settings("repeat")("value")) - 1,
                           CInt(settings("repeat")("value")) * 60 - 1)

        DurationRepeat.Interval = 1000
        DurationRepeat.Start()
    End Select
  End Sub

  Private Sub Disabled()
    ComboTypeClick.Enabled = AFK
    RepeatBtn.Enabled = AFK
    DelayBtn.Enabled = AFK
    SettingBtn.Enabled = AFK
    MousePic.Enabled = AFK

    HoldClickOpt()
    ACpassiveClick()
    SettingBtn.Image = My.Resources.setting_8
    StartTimer.Stop()
    ClickTimer.Stop()
    LongClickTimer.Stop()
    DurationRepeat.Stop()

    AFK = False
  End Sub

  Private Sub StartTimer_Tick(sender As Object, e As EventArgs) Handles StartTimer.Tick
    Dim settings As JObject = GetSettings("user.umc")
    DelaySet()
    If CInt(settings("type")) = 2 Then PressSet()

    If AFK = True Then
      If CInt(settings("duration")("type")) = 1 Then timeDelay = CInt(settings("duration")("value")) - 1
      If CInt(settings("duration_click")("type")) = 1 Then timePress = CInt(settings("duration_click")("value")) - 1
      Clicked()

      If Not CInt(settings("type")) = 2 Then ClickTimer.Start()
      StartTimer.Stop()
    End If
  End Sub

  Private Sub ClickTimer_Tick(sender As Object, e As EventArgs) Handles ClickTimer.Tick
    Dim settings As JObject = GetSettings("user.umc")

    If AFK = True Then
      Select Case timeDelay
        Case 0
          If CInt(settings("duration")("type")) = 1 Then timeDelay = CInt(settings("duration")("value")) - 1

          Clicked()
        Case Else
          timeDelay -= 1
      End Select
    End If
  End Sub

  Private Sub LongClick_Tick(sender As Object, e As EventArgs) Handles LongClickTimer.Tick
    Dim settings As JObject = GetSettings("user.umc")

    If AFK = True Then
      Select Case timePress
        Case 0
          If CInt(settings("duration_click")("type")) = 1 Then timePress = CInt(settings("duration_click")("value")) - 1

          If CInt(settings("click")) = 0 Then LeftUp()
          If CInt(settings("click")) = 1 Then RightUp()

          ClickTimer.Start()
          LongClickTimer.Stop()
        Case Else
          timePress -= 1
      End Select
    End If
  End Sub

  Private Sub DelayTime_Tick(sender As Object, e As EventArgs) Handles DurationRepeat.Tick
    Select Case secondRepeat
      Case 0
        Disabled()
      Case Else
        secondRepeat -= 1
    End Select
  End Sub

  Private Sub DelaySet()
    Dim settings As JObject = GetSettings("user.umc")
    If CInt(settings("duration")("type")) = 0 Then
      ClickTimer.Interval = settings("duration")("value")
    Else
      ClickTimer.Interval = 1000
    End If
  End Sub

  Private Sub PressSet()
    Dim settings As JObject = GetSettings("user.umc")
    If CInt(settings("duration_click")("type")) = 0 Then
      LongClickTimer.Interval = settings("duration_click")("value")
    Else
      LongClickTimer.Interval = 1000
    End If
  End Sub

  Private Sub Clicked()
    Dim settings As JObject = GetSettings("user.umc")

    If CInt(settings("repeat")("type")) = 1 Then
      Select Case valueRepeat
        Case 0
          Disabled()
        Case Else
          valueRepeat -= 1
      End Select
    End If

    If CInt(settings("click")) = 0 Then
      LeftClicked()
    ElseIf CInt(settings("click")) = 1 Then
      RightClicked()
    End If
  End Sub

  Private Sub LeftClicked()
    Dim settings As JObject = GetSettings("user.umc")

    Select Case CInt(settings("type"))
      Case 0
        LeftClick()
      Case 1
        LeftClick()
        LeftClick()
      Case 2
        LeftDown()
        LongClickTimer.Start()
        ClickTimer.Stop()
    End Select
  End Sub

  Private Sub RightClicked()
    Dim settings As JObject = GetSettings("user.umc")

    Select Case CInt(settings("type"))
      Case 0
        RightClick()
      Case 1
        RightClick()
        RightClick()
      Case 2
        RightDown()
        LongClickTimer.Start()
        ClickTimer.Stop()
    End Select
  End Sub
End Class
