Imports System.Text

Public Class ClsEncryptDecryptFiles

  Public Sub New(_KEY As String)

    KeyStr = _KEY

  End Sub

  Private KeyValue As String
  Public Property KeyStr() As String
    Get
      Return KeyValue
    End Get
    Set(ByVal value As String)
      KeyValue = value
    End Set
  End Property

  Function Encryption(ByVal str As String) As Byte()

    Dim input As Byte() = Encoding.Default.GetBytes(str) 'File.ReadAllBytes(Path)

    Dim AES As New System.Security.Cryptography.RijndaelManaged
    Dim SHA256hash As System.Security.Cryptography.SHA256
    Try
      SHA256hash = New System.Security.Cryptography.SHA256Cng
    Catch ex As PlatformNotSupportedException
      SHA256hash = System.Security.Cryptography.SHA256.Create()
    End Try
    Dim ciphertext As String = ""
    'Try
    AES.Key = SHA256hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(KeyStr))
    AES.Mode = Security.Cryptography.CipherMode.ECB
    Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
    Dim Buffer As Byte() = input
    Return DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
    'Catch ex As Exception
    'End Try
  End Function

  Function Decryption(ByVal input As Byte()) As Byte()

    'Dim input As Byte() = Encoding.Default.GetBytes(Str) 'File.ReadAllBytes(Path)

    Dim AES As New System.Security.Cryptography.RijndaelManaged
    Dim SHA256hash As System.Security.Cryptography.SHA256
    Try
      SHA256hash = New System.Security.Cryptography.SHA256Cng
    Catch ex As PlatformNotSupportedException
      SHA256hash = System.Security.Cryptography.SHA256.Create()
    End Try
    'Try
    AES.Key = SHA256hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(KeyStr))
    AES.Mode = Security.Cryptography.CipherMode.ECB
    Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
    Dim Buffer As Byte() = input
    Return DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
    'Catch ex As Exception
    'End Try
  End Function

End Class
