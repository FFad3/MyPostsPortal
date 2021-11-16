using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Application.Services.Utilities
{
    internal class DataHashing
    {
        internal static string StringToHash(string input)
        {
            // To calculate MD5 hash from an input string
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);// string =>bytes

            byte[] hash = md5.ComputeHash(inputBytes);//hashing

            // convert byte array to hex string
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                //to make hex string use lower case instead of uppercase add parameter "X2"
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
