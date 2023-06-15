using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace dental_manager.HandleCode
{
    public class HandleCode
    {
        public static string encodeString()
        {
            string data = "GeeksForGeeks Text";
            string answer = "";
            string publicKey = "GEEK1234";
            string privateKey = "PKEY4321";
            byte[] privateKeyBytes = { };
            privateKeyBytes = Encoding.UTF8.GetBytes(privateKey);
            byte[] publicKeyBytes = { };
            publicKeyBytes = Encoding.UTF8.GetBytes(publicKey);
            byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(data);
            using (AesCryptoServiceProvider provider = new AesCryptoServiceProvider())
            {
                var memoryStream = new MemoryStream();
                var cryptoStream = new CryptoStream(memoryStream,
                provider.CreateEncryptor(publicKeyBytes, privateKeyBytes),
                CryptoStreamMode.Write);
                cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                cryptoStream.FlushFinalBlock();
                answer = Convert.ToBase64String(memoryStream.ToArray());
            }
            return answer;
        }

        public static string decodeString(String data)
        {
            string answer = "";
            string publicKey = "GEEK1234";
            string privateKey = "PKEY4321";
            byte[] privateKeyBytes = { };
            privateKeyBytes = Encoding.UTF8.GetBytes(privateKey);
            byte[] publicKeyBytes = { };
            publicKeyBytes = Encoding.UTF8.GetBytes(publicKey);
            byte[] inputByteArray = new byte[data.Replace(" ", "+").Length];
            inputByteArray = Convert.FromBase64String(data.Replace(" ", "+"));
            using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
            {
                var memoryStream = new MemoryStream();
                var cryptoStream = new CryptoStream(memoryStream,
                provider.CreateDecryptor(publicKeyBytes, privateKeyBytes),
                CryptoStreamMode.Write);
                cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                cryptoStream.FlushFinalBlock();
                answer = Encoding.UTF8.GetString(memoryStream.ToArray());
            }
            return answer;
        }

    }
}
