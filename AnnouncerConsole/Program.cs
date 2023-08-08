using System.IO;
using System;
using System.Text;
using AnnouncerCore.Security;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;

internal class Program
{
    public static void Main(string[] args)
    {
        var config = GetConfig();

        //AesAlgorythm aesAlgorythm = new AesAlgorythm() { IV = config.GetSection("IV").Value, Key = config.GetSection("Key").Value };
        
        AesKeyIV aesAlg = new AesKeyIV();
        using (var aes = Aes.Create())
        {
            aes.GenerateIV();
            aesAlg.IV = aes.IV;
            aes.GenerateKey();
            aesAlg.Key = aes.Key;
        }

        var e = Encryption.Encrypt("test wojtka", aesAlg);
        var d = Encryption.Decipher(e, aesAlg);
        var c = Encoding.UTF8.GetString(d);
        var sd = c.ToString();

    }

    public static IConfiguration GetConfig()
    {
        var builder = new ConfigurationBuilder()
                     .SetBasePath(Directory.GetCurrentDirectory())
                     .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        return builder.Build();
    }
}