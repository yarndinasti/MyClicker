Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq, System.IO
Module SaveServices
  Public Function GetSettings(files) As JObject
    Return JObject.Parse(File.ReadAllText(Path.Combine(Dir, files)))
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

    File.WriteAllText(Path.Combine(Dir, files), Settings.ToString)
  End Sub
End Module
