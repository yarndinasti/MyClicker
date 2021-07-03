Imports Newtonsoft.Json.Linq, System.IO
Module init
  Public Sub initial()
    'Click
    Select Case CInt(SaveServices.GetSettings("user.json")("click"))
      Case 0
        Form1.MousePic.Image = My.Resources.left_8
        Form1.MousePic.Tag = 1
      Case 1
        Form1.MousePic.Image = My.Resources.right_8
        Form1.MousePic.Tag = 0
    End Select

    ResetTimeView()
    ResetRepeatView()
    ResetTimeClickView()
  End Sub

  Public Sub HoldClickOpt()
    If Form1.ComboTypeClick.Text = "Press Click" Then
      Form1.HoldClickPic.Image = My.Resources.click_time_8
      Form1.HoldClickBtn.Enabled = True
    Else
      Form1.HoldClickPic.Image = My.Resources.disable_click_time_8
      Form1.HoldClickBtn.Enabled = False
    End If
  End Sub

  Public Sub ChangeClick()
    SaveSettings("user.json", "click", CInt(Form1.MousePic.Tag))

    If Form1.MousePic.Tag = "1" Then
      Form1.MousePic.Image = My.Resources.right_8
      Form1.MousePic.Tag = "0"
    ElseIf Form1.MousePic.Tag = "0" Then
      Form1.MousePic.Image = My.Resources.left_8
      Form1.MousePic.Tag = "1"
    End If
  End Sub

  Public Sub ResetRepeatView()
    Dim settings As JObject = GetSettings("user.json")
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

    Form1.LblRepeat.Text = IIf(Not CInt(settings("repeat")("type")) = 0,
                               CStr(settings("repeat")("value")) + " ", "") + count
    If CInt(settings("repeat")("type")) = 0 Then
      Form1.RepeatPic.Image = My.Resources.disable_repeat_8
    Else
      Form1.RepeatPic.Image = My.Resources.repeat_8
    End If
  End Sub

  Public Sub ResetTimeView()
    Dim settings As JObject = GetSettings("user.json")
    Dim count As String = ""

    Select Case CInt(settings("duration")("type"))
      Case 0
        count = "ms"
      Case 1
        count = "sec"
    End Select

    Form1.DelayLbl.Text = CStr(settings("duration")("value")) + " " + count
  End Sub

  Public Sub ResetTimeClickView()
    Dim settings As JObject = GetSettings("user.json")
    Dim count As String = ""

    Select Case CInt(settings("duration_click")("type"))
      Case 0
        count = "ms"
      Case 1
        count = "sec"
    End Select

    Form1.HoldClickLbl.Text = CStr(settings("duration_click")("value")) + " " + count
  End Sub
End Module
