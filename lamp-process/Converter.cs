using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamp_process
{
    public interface IConverter
    {
        string Encrypt(string input);
        string Decrypt(string input);
    }

    public class Base64Converter : IConverter
    {
        public string Encrypt(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(bytes);
        }

        public string Decrypt(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            var bytes = Convert.FromBase64String(input);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }

    internal class Converter
    {

    }
}
