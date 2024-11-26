using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamp_process
{
    public interface IConverter
    {
        string Encrypt(string input); // Şifreler veya dönüştürür
        string Decrypt(string input); // Şifrelenmiş/dönüştürülmüş veriyi geri çevirir
    }

    public class Base64Converter : IConverter
    {
        public string Encrypt(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            var bytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(bytes);
        }

        public string Decrypt(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            var bytes = Convert.FromBase64String(input);
            return Encoding.UTF8.GetString(bytes);
        }
    }

    public class UnixTimeHelper
    {
        public long DateTimeToUnix(DateTime dateTime)
        {
            return new DateTimeOffset(dateTime).ToUnixTimeSeconds();
        }

        public DateTime UnixToDateTime(long unixTime)
        {
            return DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;
        }
    }
}
