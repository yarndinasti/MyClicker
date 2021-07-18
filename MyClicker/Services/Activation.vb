Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Module Activation
  Public Sub Activated()
    Dim keylisence As SKGL.Validate = New SKGL.Validate()
    Dim keyName As New ClsEncryptDecryptFiles(My.Computer.Name)
    Dim config As JObject = GetSettings("config.mcc")

    If File.Exists(Path.Combine(Dir, "key.mckey")) And CBool(config("unlock")) = False Then
      Dim fileKey As Byte() = File.ReadAllBytes(Path.Combine(Dir, "key.mckey"))
      Dim activatedFile As JObject = JObject.Parse(Encoding.Default.GetString(keyName.Decryption(fileKey)))

      keylisence.secretPhase = String.Format("{0}-{1}", My.Computer.Name, activatedFile("name"))
      keylisence.Key = activatedFile("key")

      If keylisence.IsValid = True Then
        MessageBox.Show("Thanks for activated this program!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        SaveSettings("config.mcc", "unlock", True)
        SaveSettings("config.mcc", "donate", False)
        SaveSettings("config.mcc", "name", activatedFile("name"))
      End If
    End If
  End Sub
End Module
