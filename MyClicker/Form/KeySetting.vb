Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class KeySetting

  Public id, getKey1, getKey2 As Integer
  Dim ConfigFile As New ClsEncryptDecryptFiles(My.Computer.Name)

  Dim key1 As Dictionary(Of Integer, String)
  Dim key2 As Dictionary(Of Integer, String)

  Dim KeyKode1 As Integer() = {0, 16, 17, 18}
  Dim KeyString1 As String() = {"", "Shift", "Ctrl", "Alt"}

  Private Sub KeySetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    key1 = New Dictionary(Of Integer, String)

    For i = 0 To KeyKode1.Length - 1
      key1.Add(KeyKode1(i), KeyString1(i))
    Next

    ComKeyHandler.DisplayMember = "Value"
    ComKeyHandler.ValueMember = "Key"
    ComKeyHandler.DataSource = New BindingSource(key1, Nothing)

    key2 = New Dictionary(Of Integer, String)

    For i = 0 To KeyValues().Length - 1
      key2.Add(KeyValues(i), KeyStrings(i))
    Next

    ComKey.DisplayMember = "Value"
    ComKey.ValueMember = "Key"
    ComKey.DataSource = New BindingSource(key2, Nothing)

    btnKey.Enabled = False

    ComKeyHandler.SelectedValue = getKey2
    ComKey.SelectedValue = getKey1

    ComKeyHandler.Enabled = id > 0

    AddHandler KeyUp, AddressOf SearchKey
    AddHandler ComKeyHandler.KeyUp, AddressOf SearchKey
    AddHandler ComKey.KeyUp, AddressOf SearchKey
    AddHandler btnKey.KeyUp, AddressOf SearchKey
  End Sub

  Private Sub SelectedKey(sender As Object, e As EventArgs) Handles ComKeyHandler.SelectedIndexChanged, ComKey.SelectedIndexChanged
    btnKey.Enabled = CBool(Not (ComKeyHandler.SelectedValue = getKey2 And ComKey.SelectedValue = getKey1))
  End Sub

  Private Sub SearchKey(sender As Object, e As KeyEventArgs)
    If KeyKode1.Contains(e.KeyValue) And id > 1 Then
      ComKeyHandler.SelectedValue = e.KeyValue
    End If

    If e.KeyValue = 27 And id > 1 Then
      ComKeyHandler.SelectedValue = 0
    End If

    If KeyValues.Contains(e.KeyValue) Then
      ComKey.SelectedValue = e.KeyValue
    End If
  End Sub

  Private Sub btnKey_Click(sender As Object, e As EventArgs) Handles btnKey.Click
    Dim config As JObject = GetSettings("config.mcc")

    Dim arrayKeys As Integer() = {}
    Dim stringKeys As String = ""
    Dim configKeys As String = ""

    Select Case ComKeyHandler.Text
      Case ""
        arrayKeys = {ComKey.SelectedValue}
        stringKeys = ComKey.Text
      Case Else
        arrayKeys = {ComKey.SelectedValue, ComKeyHandler.SelectedValue}
        stringKeys = String.Format("{0} + {1}", ComKeyHandler.Text, ComKey.Text)
    End Select

    Select Case id
      Case 0
        configKeys = "key_play"
      Case 1
        configKeys = "key_disable"
      Case 2
        configKeys = "key_change_click"
    End Select

    If SameKey(arrayKeys) = False Then
      MessageBox.Show("This Key is same to another config", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

      Return
    End If

    config(configKeys)("value") = JArray.FromObject(arrayKeys)
    config(configKeys)("string") = stringKeys

    Dim save As Byte() = ConfigFile.Encryption(config.ToString)
    File.WriteAllBytes(Path.Combine(Dir, "config.mcc"), save)

    SettingsFrm.RefreshKey()
    Close()
  End Sub

  Private Sub btnKey_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKey.KeyDown
    If KeyKode1.Contains(e.KeyValue) And KeyValues.Contains(e.KeyValue) Then
      e.Handled = False
    End If
  End Sub

  Private Function SameKey(arrayKeys As Integer()) As Boolean
    Dim config As JObject = GetSettings("config.mcc")
    Dim Returning As Boolean = True

    Dim keyPlay As Integer() = config("key_play")("value").ToObject(Of Integer())()
    Dim keyDisabled As Integer() = config("key_disable")("value").ToObject(Of Integer())()
    Dim keyMouse As Integer() = config("key_change_click")("value").ToObject(Of Integer())()

    If (arrayKeys(0) = keyPlay(0)) And (Not id = 0) And (arrayKeys.Length = 1) Then
      Returning = False
    End If

    If (arrayKeys(0) = keyDisabled(0)) And (Not id = 1) Then
      Select Case arrayKeys.Length
        Case 1
          Returning = False
        Case 2
          If arrayKeys(1) = keyDisabled(1) Then
            Returning = False
          End If
      End Select
    End If

    If (arrayKeys(0) = keyMouse(0)) And (Not id = 2) Then
      Select Case arrayKeys.Length
        Case 1
          Returning = False
        Case 2
          If arrayKeys(1) = keyMouse(1) Then
            Returning = False
          End If
      End Select
    End If

    Return Returning
  End Function
End Class