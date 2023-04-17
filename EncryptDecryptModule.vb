Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Module EncryptDecryptModule
    Private tripleDes As New TripleDESCryptoServiceProvider

    Public Function EncryptData(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms, tripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)

    End Function

    Public Function DecryptData(ByVal encryptedtext As String) As String
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)
        Dim ms As New System.IO.MemoryStream
        Dim decStream As New CryptoStream(ms, tripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Module
