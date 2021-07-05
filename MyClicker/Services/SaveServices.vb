Imports System.Text.RegularExpressions, System.Text
Imports Newtonsoft.Json.Linq, System.IO
Module SaveServices
  Dim EncFile As New ClsEncryptDecryptFiles(":@]@_W.msJ:L,7Uf")

  Public Function GetSettings(files) As JObject
    Dim fileSettings = File.ReadAllBytes(Path.Combine(Dir, files))
    fileSettings = EncFile.Decryption(fileSettings)
    Dim strSettings = Encoding.Default.GetString(fileSettings)

    Return JObject.Parse(strSettings)
  End Function

  Public Sub SaveSettings(files As String, key As String, value As String, Optional key2 As String = "")
    Dim Settings As JObject = GetSettings(files)

    If key2 = "" Then
      If Regex.IsMatch(value, "^[0-9]+$") Then
        Settings(key) = CInt(value)
      ElseIf Regex.IsMatch(value.ToLower, "^(true|false)+$") Then
        Settings(key) = CBool(value)
      Else
        Settings(key) = value
      End If
    Else
      If Regex.IsMatch(value, "^[0-9]+$") Then
        Settings(key)(key2) = CInt(value)
      ElseIf Regex.IsMatch(value.ToLower, "^(true|false)+$") Then
        Settings(key)(key2) = CBool(value)
      Else
        Settings(key)(key2) = value
      End If
    End If

    Dim save As Byte() = EncFile.Encryption(Settings.ToString)
    File.WriteAllBytes(Path.Combine(Dir, files), save)
  End Sub
End Module
