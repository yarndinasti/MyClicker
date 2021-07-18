Imports Newtonsoft.Json.Linq, System.IO
Module First
  Public Dir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\yansaan\MyClicker"
  Dim UserFile As New ClsEncryptDecryptFiles(":@]@_W.msJ:L,7Uf")
  Dim ConfigFile As New ClsEncryptDecryptFiles(My.Computer.Name)

  Public Sub FirstUsrSettings()
    'Check Folder
    If Not Directory.Exists(Dir) Then
      Directory.CreateDirectory(Dir)
    End If

    If Not File.Exists(Path.Combine(Dir, "user.umc")) Then
      Dim userSettings As Byte() = UserFile.Encryption(CreateUsrFile())
      File.WriteAllBytes(Path.Combine(Dir, "user.umc"), userSettings)
    End If

    If Not File.Exists(Path.Combine(Dir, "config.mcc")) Then
      Dim userSettings As Byte() = ConfigFile.Encryption(CreateConfigFile())
      File.WriteAllBytes(Path.Combine(Dir, "config.mcc"), userSettings)
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

  Private Function CreateConfigFile() As String
    Dim playKey As JObject = New JObject(New JProperty("value", New JArray(117)),
                                         New JProperty("string", "F6"))
    Dim disableKey As JObject = New JObject(New JProperty("value", New JArray(117, 18)),
                                            New JProperty("string", "Alt + F6"))
    Dim mouseKey As JObject = New JObject(New JProperty("value", New JArray(117, 16)),
                                          New JProperty("string", "Shift + F6"))

    Return New JObject(New JProperty("name", ""),
                       New JProperty("notify", True),
                       New JProperty("debug", False),
                       New JProperty("donate", True),
                       New JProperty("unlock", False),
                       New JProperty("key_play", playKey),
                       New JProperty("key_disable", disableKey),
                       New JProperty("key_change_click", mouseKey)).ToString
  End Function
End Module