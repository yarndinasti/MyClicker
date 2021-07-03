Imports Newtonsoft.Json.Linq

Public Class Form1
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Call First.FirstUsrSettings()

    Dim data As JObject = GetSettings("user.json")
    initial()
    Dim TypeClicks() As String = {"Single Click", "Double Click", "Press Click"}
    For Each TypeClick As String In TypeClicks
      ComboTypeClick.Items.Add(TypeClick)
    Next

    ComboTypeClick.SelectedIndex = data("type")
    HoldClickOpt()
  End Sub

  Private Sub ComboTypeClick_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTypeClick.SelectedIndexChanged
    SaveSettings("user.json", "type", ComboTypeClick.SelectedIndex)
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
End Class
