Imports System.Text
Imports Newtonsoft.Json.Linq, System.IO
Module init
  Public Sub initial()
    'Click
    Select Case CInt(SaveServices.GetSettings("user.umc")("click"))
      Case 0
        MainFrm.MousePic.Image = My.Resources.left_8
        MainFrm.MousePic.Tag = 1
      Case 1
        MainFrm.MousePic.Image = My.Resources.right_8
        MainFrm.MousePic.Tag = 0
    End Select

    ResetTimeView()
    ResetRepeatView()
    ResetTimeClickView()
  End Sub

  Public Sub HoldClickOpt()
    If MainFrm.ComboTypeClick.Text = "Press Click" Then
      MainFrm.HoldClickPic.Image = My.Resources.click_time_8
      MainFrm.HoldClickBtn.Enabled = True
    Else
      MainFrm.HoldClickPic.Image = My.Resources.disable_click_time_8
      MainFrm.HoldClickBtn.Enabled = False
    End If
  End Sub

  Public Sub ChangeClick()
    SaveSettings("user.umc", "click", CInt(MainFrm.MousePic.Tag))

    If MainFrm.MousePic.Tag = "1" Then
      MainFrm.MousePic.Image = My.Resources.right_8
      MainFrm.MousePic.Tag = "0"
      MainFrm.NotifyIcon1.Icon = My.Resources.right_cursor
    ElseIf MainFrm.MousePic.Tag = "0" Then
      MainFrm.MousePic.Image = My.Resources.left_8
      MainFrm.MousePic.Tag = "1"
      MainFrm.NotifyIcon1.Icon = My.Resources.left_cursor
    End If
  End Sub

  Public Sub ResetRepeatView()
    Dim settings As JObject = GetSettings("user.umc")
    Dim count As String = ""

    Select Case CInt(settings("repeat")("type"))
      Case 0
        count = "Unlimited"
      Case 1
        count = "click"
      Case 2
        count = "sec"
      Case 3
        count = "min"
    End Select

    MainFrm.LblRepeat.Text = IIf(Not CInt(settings("repeat")("type")) = 0,
                               CStr(settings("repeat")("value")) + " ", "") + count
    If CInt(settings("repeat")("type")) = 0 Then
      MainFrm.RepeatPic.Image = My.Resources.disable_repeat_8
    Else
      MainFrm.RepeatPic.Image = My.Resources.repeat_8
    End If
  End Sub

  Public Sub ResetTimeView()
    Dim settings As JObject = GetSettings("user.umc")
    Dim count As String = ""

    Select Case CInt(settings("duration")("type"))
      Case 0
        count = "ms"
      Case 1
        count = "sec"
    End Select

    MainFrm.DelayLbl.Text = CStr(settings("duration")("value")) + " " + count
  End Sub

  Public Sub ResetTimeClickView()
    Dim settings As JObject = GetSettings("user.umc")
    Dim count As String = ""

    Select Case CInt(settings("duration_click")("type"))
      Case 0
        count = "ms"
      Case 1
        count = "sec"
    End Select

    MainFrm.HoldClickLbl.Text = CStr(settings("duration_click")("value")) + " " + count
  End Sub

  Public Sub ACactiveClick()
    If MainFrm.MousePic.Tag = "1" Then
      MainFrm.MousePic.Image = My.Resources.active_left_8
      MainFrm.NotifyIcon1.Icon = My.Resources.active_left_cursor
    ElseIf MainFrm.MousePic.Tag = "0" Then
      MainFrm.MousePic.Image = My.Resources.active_right_8
      MainFrm.NotifyIcon1.Icon = My.Resources.active_right_cursor
    End If
  End Sub

  Public Sub ACpassiveClick()
    If MainFrm.MousePic.Tag = "1" Then
      MainFrm.MousePic.Image = My.Resources.left_8
      MainFrm.NotifyIcon1.Icon = My.Resources.left_cursor
    ElseIf MainFrm.MousePic.Tag = "0" Then
      MainFrm.MousePic.Image = My.Resources.right_8
      MainFrm.NotifyIcon1.Icon = My.Resources.right_cursor
    End If
  End Sub
End Module
