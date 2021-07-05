Imports Newtonsoft.Json.Linq, System.IO
Public Class RepeatFrm
  Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboRepeat.SelectedIndexChanged
    RepeatNum.Enabled = CBool(Not ComboRepeat.SelectedItem = "Unlimited")
  End Sub

  Private Sub RepeatFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboRepeat.Items.Clear()
    Dim TypeRepeats() As String = {"Unlimited", "Click", "Seconds", "Minutes"}
    For Each TypeRepeat As String In TypeRepeats
      ComboRepeat.Items.Add(TypeRepeat)
    Next

    Dim setting As JObject = GetSettings("user.umc")
    ComboRepeat.SelectedIndex = setting("repeat")("type")
    RepeatNum.Value = setting("repeat")("value")
  End Sub

  Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
    If ComboRepeat.SelectedIndex = 2 AndAlso RepeatNum.Value < 30 Then
      MessageBox.Show("Duration repeat must be between 30 seconds or more", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)

      Return

    ElseIf ComboRepeat.SelectedIndex = 1 AndAlso RepeatNum.Value < 1 Then
      MessageBox.Show("Amount repeat must be between 2 clicks or more", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error)

      Return
    End If

    SaveSettings("user.umc", "repeat", RepeatNum.Value, "value")
    SaveSettings("user.umc", "repeat", ComboRepeat.SelectedIndex, "type")

    ResetRepeatView()
    Close()
  End Sub

  Private Sub RepeatFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    Dim setting As JObject = GetSettings("user.umc")
    If Not ComboRepeat.SelectedIndex = CInt(setting("repeat")("type")) Or Not RepeatNum.Value = setting("repeat")("value") Then
      Dim confirm As DialogResult = MessageBox.Show("Do you want to exit without saving your settings?",
                                                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      e.Cancel = CBool(confirm = DialogResult.No)
    End If
  End Sub
End Class