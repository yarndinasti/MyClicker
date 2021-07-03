Imports Newtonsoft.Json.Linq, System.IO
Module First
  Public Dir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\yansaan\MyClicker"
  Public Sub FirstUsrSettings()
    'Check Folder
    If Not Directory.Exists(Dir) Then
      Directory.CreateDirectory(Dir)
    End If

    If Not File.Exists(Path.Combine(Dir, "user.json")) Then
      File.WriteAllText(Path.Combine(Dir, "user.json"), CreateUsrFile())
    End If
  End Sub

  Private Function CreateUsrFile() As String
    Dim duration As JObject = New JObject(New JProperty("value", 250),
                                          New JProperty("type", 0))

    Dim repeat As JObject = New JObject(New JProperty("value", 2),
                                          New JProperty("type", 0))

    Return New JObject(New JProperty("click", 0),
                       New JProperty("repeat", repeat),
                       New JProperty("type", 0),
                       New JProperty("duration", duration),
                       New JProperty("duration_click", duration)).ToString
  End Function
End Module
