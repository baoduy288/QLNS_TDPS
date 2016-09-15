using System.Text;
using System.Security.Cryptography;

namespace QLNS_MVC.Common
{
    public static class Encryptor
    {
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //Compute hash result after compute it.
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //Get hash result after computed it.
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();

            for(int i = 0; i < result.Length; i++)
            {
                //Change it into 2 hexadecimal digits for each byte.
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}