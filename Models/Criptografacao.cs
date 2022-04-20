using System;
using System.Security.Cryptography;
using System.Text;

namespace Biblioteca.Models
{
    public class Criptografacao
    {
        public static string TextCrip (string textNorm)
        {
            MD5 MD5Hasher = MD5.Create();

            byte[] By = Encoding.Default.GetBytes(textNorm);
            byte[] bytesCrip = MD5Hasher.ComputeHash(By);

            StringBuilder SB = new StringBuilder();

            foreach (byte b in bytesCrip)
            {
                string DebugB = b.ToString("x2");
                SB.Append(DebugB);
            }

            return SB.ToString();
        }
    }
}