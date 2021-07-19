Imports IWshRuntimeLibrary
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class SettingsFrm
  Dim config As JObject
  Dim ShortcutPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Application.ProductName) & ".lnk"
  Private Sub SettingsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    CenterToScreen()
    config = GetSettings("config.mcc")
    RefreshKey()

    If KeyList.SelectedItems.Count <= 0 Then
      Button1.Enabled = False
    End If

    TaskbarCheck.Checked = CBool(config("notify"))
    StartupCombo.Checked = IO.File.Exists(ShortcutPath)
    DebugCombo.Checked = CBool(config("debug"))
    DonateCombo.Checked = CBool(config("donate"))

    VersionLbl.Text = String.Format("v{0}", My.Application.Info.Version)
    Dim status As String = IIf(CBool(config("unlock")) = True, "Full", "Limited")
    ComName.Text = String.Format("Name: {0} ({1})", config("name"), status)
    NameLbl.Text = My.Application.Info.Copyright
  End Sub

  Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KeyList.SelectedIndexChanged
    Button1.Enabled = KeyList.SelectedItems.Count > 0
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    config = GetSettings("config.mcc")
    Dim getKeyConfig As String = ""

    Select Case KeyList.FocusedItem.Index
      Case 0
        getKeyConfig = "key_play"
      Case 1
        getKeyConfig = "key_disable"
      Case 2
        getKeyConfig = "key_change_click"
    End Select

    KeySetting.id = KeyList.FocusedItem.Index
    KeySetting.getKey1 = CInt(config(getKeyConfig)("value")(0))

    Select Case config(getKeyConfig)("value").Count
      Case 1
        KeySetting.getKey2 = 0
      Case Else
        KeySetting.getKey2 = config(getKeyConfig)("value")(1)
    End Select

    KeySetting.ShowDialog()
  End Sub

  Private Sub ChangeListView(list, value)
    Dim keys As ListViewItem = New ListViewItem(CStr(list))
    keys.SubItems.Add(value)
    KeyList.Items.Add(keys)
  End Sub

  Public Sub RefreshKey()
    config = GetSettings("config.mcc")

    KeyList.Items.Clear()
    ChangeListView("Start/Stop", CStr(config("key_play")("string")))
    ChangeListView("Enabled/Disabled", CStr(config("key_disable")("string")))
    ChangeListView("Change Mouse Click", CStr(config("key_change_click")("string")))
  End Sub

  Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
    config = GetSettings("config.mcc")
    Dim ConfigFile As New ClsEncryptDecryptFiles(My.Computer.Name)

    Dim result As DialogResult = MessageBox.Show("You want to reset all key to default?", "Reset",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    If result = DialogResult.Yes Then
      config("key_play")("value") = JArray.FromObject({117})
      config("key_play")("string") = "F6"
      config("key_disable")("value") = JArray.FromObject({117, 18})
      config("key_disable")("string") = "Alt + F6"
      config("key_change_click")("value") = JArray.FromObject({117, 16})
      config("key_change_click")("string") = "Shift + F6"

      Dim save As Byte() = ConfigFile.Encryption(config.ToString)
      IO.File.WriteAllBytes(Path.Combine(Dir, "config.mcc"), save)

      RefreshKey()
    End If
  End Sub

  Private Sub TaskbarCheck_CheckChanged(sender As Object, e As EventArgs) Handles TaskbarCheck.CheckedChanged
    SaveSettings("config.mcc", "notify", TaskbarCheck.Checked)
  End Sub

  Private Sub makeSoutcut()
    Dim WshShell As WshShell = New WshShell()

    Dim Shortcut As IWshShortcut = CType(WshShell.CreateShortcut(ShortcutPath), IWshShortcut)
    Shortcut.TargetPath = Application.ExecutablePath
    Shortcut.WorkingDirectory = Application.StartupPath
    Shortcut.Arguments = "-h"
    Shortcut.Description = ""
    Shortcut.Save()
  End Sub

  Private Sub DebugCombo_CheckedChanged(sender As Object, e As EventArgs) Handles DebugCombo.CheckedChanged
    SaveSettings("config.mcc", "debug", DebugCombo.Checked)

    If DebugCombo.Checked = True Then
      Stats.Show()
    Else
      Stats.Close()
    End If
  End Sub

  Private Sub DonateCombo_Click(sender As Object, e As EventArgs) Handles DonateCombo.Click
    config = GetSettings("config.mcc")
    If CBool(config("unlock")) = False Then
      Dim result As DialogResult = MessageBox.Show("For turn off this feature, please activate this program", "Donation",
                                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

      If result = DialogResult.OK Then
        Process.Start("https://yansaanid.github.io/myclicker/donate.html")
      End If
      DonateCombo.Checked = True
    Else
      SaveSettings("config.mcc", "donate", DonateCombo.Checked)
    End If
  End Sub

  Private Sub SettingsFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    MainFrm.HotKeyTimer.Start()
  End Sub

  Private Sub StartupCombo_CheckedChanged(sender As Object, e As EventArgs) Handles StartupCombo.CheckedChanged
    If StartupCombo.Checked = True And Not IO.File.Exists(ShortcutPath) Then
      makeSoutcut()
    Else
      IO.File.Delete(ShortcutPath)
    End If
  End Sub

  Private Sub sourceLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles sourceLink.LinkClicked
    Process.Start("https://github.com/yansaan/MyClicker")
  End Sub

  Private Sub YoutubeLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles YoutubeLink.LinkClicked
    Process.Start("https://youtube.com/yansaanyt")
  End Sub

  Private Sub ACirclesLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ACirclesLink.LinkClicked
    Process.Start("https://youtube.com/acirclesid")
  End Sub

  Private Sub TwitterLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TwitterLink.LinkClicked
    Process.Start("https://twitter.com/yansaan_")
  End Sub

  Private Sub InstagramLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles InstagramLink.LinkClicked
    Process.Start("https://instagram.com/yansaan_")
  End Sub

  Private Sub FacebookLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FacebookLink.LinkClicked
    Process.Start("https://fb.me/yansaanxyz")
  End Sub

  Private Sub TikTokLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TikTokLink.LinkClicked
    Process.Start("https://tiktok.com/@yansaan")
  End Sub

  Private Sub TwitchLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TwitchLink.LinkClicked
    Process.Start("https://twitch.tv/yansaan_")
  End Sub

  Private Sub KaryaLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles KaryaLink.LinkClicked
    Process.Start("https://karyakarsa.com/yansaan")
  End Sub

  Private Sub TrakteerLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TrakteerLink.LinkClicked
    Process.Start("https://trakteer.id/yansaan")
  End Sub

  Private Sub PatreonLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PatreonLink.LinkClicked
    Process.Start("https://patreon.com/yansaan_")
  End Sub

  Private Sub SaweriaLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SaweriaLink.LinkClicked
    Process.Start("https://saweria.co/yansaan")
  End Sub

  Private Sub SteamlabsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SteamlabsLink.LinkClicked
    Process.Start("https://streamlabs.com/ianardiansyahianongplus")
  End Sub

  Private Sub WebsiteLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WebsiteLink.LinkClicked
    Process.Start("https://yansaanid.github.io")
  End Sub

  Private Sub GitHubLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GitHubLink.LinkClicked
    Process.Start("https://github.com/yansaan")
  End Sub

  Private Sub DonateBtn_Click(sender As Object, e As EventArgs) Handles DonateBtn.Click
    Process.Start("https://yansaanid.github.io/myclicker/donate.html")
  End Sub

  Private Sub WikiBtn_Click(sender As Object, e As EventArgs) Handles WikiBtn.Click
    Process.Start("https://github.com/yansaan/MyClicker/wiki")
  End Sub
End Class