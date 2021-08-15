﻿Imports Newtonsoft.Json.Linq

Public Class TimeFrm
  Public form_id As Integer

  Private Sub TimeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim settings As JObject = GetSettings("user.umc")
    Dim variable As String = IIf(form_id = 1, "duration", "duration_click")

    ComboTime.Items.Clear()
    Dim TypeTimes() As String = {"Miliseconds", "Seconds"}
    For Each TypeTime As String In TypeTimes
      ComboTime.Items.Add(TypeTime)
    Next

    Text = "Edit Duration" + IIf(form_id = 2, " Click", "") + " Delay"

    NumTime.Value = settings(variable)("value")
    ComboTime.SelectedIndex = settings(variable)("type")
  End Sub

  Private Sub TimeBtn_Click(sender As Object, e As EventArgs) Handles TimeBtn.Click
    Dim variable As String = IIf(form_id = 1, "duration", "duration_click")

    If ComboTime.SelectedIndex = 0 Then
      If NumTime.Value > 20000 Then
        MessageBox.Show(String.Format("Duration delay must be between {0}ms - 20000ms",
                        IIf(form_id = 1, "30", "100")), "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error)

        Return
      End If

      Select Case form_id
        Case 1
          If NumTime.Value < 30 Then
            MessageBox.Show("Duration delay must be between 30ms - 20000ms", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
          End If
        Case 2
          If NumTime.Value < 100 Then
            MessageBox.Show("Duration delay must be between 100ms - 20000ms", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
          End If
      End Select
    End If

    SaveSettings("user.umc", variable, NumTime.Value, "value")
    SaveSettings("user.umc", variable, ComboTime.SelectedIndex, "type")

    ResetTimeView()
    ResetTimeClickView()
    Close()
  End Sub

  Private Sub TimeFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    Dim setting As JObject = GetSettings("user.umc")
    Dim variable As String = IIf(form_id = 1, "duration", "duration_click")

    If Not ComboTime.SelectedIndex = CInt(setting(variable)("type")) Or Not NumTime.Value = setting(variable)("value") Then
      Dim confirm As DialogResult = MessageBox.Show("Do you want to exit without saving your settings?",
                                                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      e.Cancel = CBool(confirm = DialogResult.No)
    End If

    If e.Cancel = False Then
      MainFrm.HotKeyTimer.Start()
    End If
  End Sub
End Class