

using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace AnnouncerCore.Security
{
    public static class Encryption
    {
        public static byte[] Encrypt(string text, AesKeyIV keyIV)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = keyIV.Key;
                return aes.EncryptCbc(Encoding.UTF8.GetBytes(text), keyIV.IV, PaddingMode.PKCS7);
            }
        }
        public static byte[] Decipher(byte[] encryptedText, AesKeyIV keyIV)
        {
            using(var aes = Aes.Create())
            {
                aes.Key = keyIV.Key;
                return aes.DecryptCbc(encryptedText, keyIV.IV, PaddingMode.PKCS7);
            }
        }
    }
}
