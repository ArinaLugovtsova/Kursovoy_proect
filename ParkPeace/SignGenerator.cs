using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
namespace ParkPeace
{
    public static class SignGenerator
    {
        public static string GetSign(string s)
        {
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();

            byte[] hash = provider.ComputeHash(Encoding.Default.GetBytes(s));

            return BitConverter.ToString(hash).ToLower().Replace("-","");



        }
    }
}