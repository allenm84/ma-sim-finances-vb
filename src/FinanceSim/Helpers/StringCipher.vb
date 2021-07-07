Imports System.Security.Cryptography
Imports System.Text

Public NotInheritable Class StringCipher
  Private Shared Function CreateProvider(password As String) As TripleDESCryptoServiceProvider
    Dim bytes = Encoding.UTF8.GetBytes(password)
    Using md5 = New MD5CryptoServiceProvider()
      Return New TripleDESCryptoServiceProvider With {
        .Key = md5.ComputeHash(bytes),
        .Mode = CipherMode.ECB,
        .Padding = PaddingMode.PKCS7
      }
    End Using
  End Function

  Private Shared Function GetKey() As String
    Return Environment.GetEnvironmentVariable("STRING_CIPHER_KEY")
  End Function

  Public Shared Function Encrypt(data As String) As String
    Return Encrypt(GetKey(), data)
  End Function

  Public Shared Function Encrypt(password As String, data As String) As String
    Using provider = CreateProvider(password)
      Dim toEncryptArray = Encoding.UTF8.GetBytes(data)
      Dim encryptor = provider.CreateEncryptor()
      Dim resultArray = encryptor.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)
      Return Convert.ToBase64String(resultArray)
    End Using
  End Function

  Public Shared Function Decrypt(data As String) As String
    Return Decrypt(GetKey(), data)
  End Function

  Public Shared Function Decrypt(password As String, data As String) As String
    Using provider = CreateProvider(password)
      Dim toDecryptArray = Convert.FromBase64String(data)
      Dim decryptor = provider.CreateDecryptor()
      Dim resultArray = decryptor.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length)
      Return Encoding.UTF8.GetString(resultArray)
    End Using
  End Function
End Class
