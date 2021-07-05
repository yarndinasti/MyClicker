Imports Newtonsoft.Json.Linq, System.IO
Module First
  Public Dir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\yansaan\MyClicker"
  Dim EncFile As New ClsEncryptDecryptFiles(":@]@_W.msJ:L,7Uf")

  Public Sub FirstUsrSettings()
    'Check Folder
    If Not Directory.Exists(Dir) Then
      Directory.CreateDirectory(Dir)
    End If

    If Not File.Exists(Path.Combine(Dir, "user.umc")) Then
      Dim userSettings As Byte() = EncFile.Encryption(CreateUsrFile())
      File.WriteAllBytes(Path.Combine(Dir, "user.umc"), userSettings)
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
