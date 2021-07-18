Imports Newtonsoft.Json.Linq

Public Class Stats

  Public WithEvents StatsTimer As New Timer
  Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    TopMost = True
    Left = 20
    Top = 10
    StatsTimer.Interval = 5
    StatsTimer.Start()
  End Sub

  Private Sub StatsTimer_Tick(sender As Object, e As EventArgs) Handles StatsTimer.Tick
    Dim settings As JObject = GetSettings("user.umc")

    LblStart.Text = String.Format("Start Timer: {0}", MainFrm.StartTimer.Enabled.ToString)
    LblDelay.Text = String.Format("Delay Timer: {0}", MainFrm.ClickTimer.Enabled.ToString)
    LblDelayTime.Text = String.Format("Duration: {0}", MainFrm.ClickTimer.Interval.ToString)
    LblDelaySec.Text = String.Format("Remaining: {0}", MainFrm.timeDelay.ToString)
    LblPress.Text = String.Format("Press Timer: {0}", MainFrm.LongClickTimer.Enabled.ToString)
    LblPressTime.Text = String.Format("Duration: {0}", MainFrm.LongClickTimer.Interval.ToString)
    LblPressSec.Text = String.Format("Remaining: {0}", MainFrm.timePress.ToString)

    Select Case CInt(settings("repeat")("type"))
      Case 0
        RepeatValueLbl.Text = "Unlimited"
      Case 1
        RepeatValueLbl.Text = String.Format("{0} Clicks", MainFrm.valueRepeat)
      Case Else
        RepeatValueLbl.Text = String.Format("{0} Seconds", MainFrm.secondRepeat)
    End Select
  End Sub
End Class