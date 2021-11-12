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
        internal static string StringToHash(string inputString)
        {
            SHA1 sha1 = SHA1.Create();

            byte[] password_bytes = Encoding.ASCII.GetBytes(inputString); // string -> bytes
            byte[] encrypted_bytes=sha1.ComputeHash(password_bytes); //Hashing

            return Convert.ToBase64String(encrypted_bytes); //return as string
        }
    }
}
