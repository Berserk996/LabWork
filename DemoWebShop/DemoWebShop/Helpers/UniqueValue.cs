using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.Helpers
{
    public static class UniqueValue
    {
        public enum TypeOfValue
        {
            nums,
            text
        }
        public static string GetUniqueValue(TypeOfValue type, int lenght = 10)
        {
            string valid = type == TypeOfValue.text ? "abcdefghijklmnopqrstuvwxyz" : "1234567890";
            StringBuilder sb = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (lenght-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    sb.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }
            return sb.ToString();
        }
    }
}
