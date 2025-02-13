using System;
using System.Buffers.Text;
using System.Text;

namespace SimplifyToolkit
{
    public interface IConverter
    {
        string Encrypt(string input);
        string Decrypt(string input);
    }

    public class Base64Convert : IConverter
    {
        public string Encrypt(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }

        public string Decrypt(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return Encoding.UTF8.GetString(Convert.FromBase64String(input));
        }
    }

    public class UnixTime
    {
        public long DateTimeToUnix(DateTime dateTime) => ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
        public long DateTimeToUnix(SimplifyDate date) => DateTimeToUnix(date.ToDateTime());
        public DateTime UnixToDateTime(long unixTime) => DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;
    }
}
