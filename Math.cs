namespace SimplifyToolkit
{
    public class Math
    {
        public static int total;
        public static int HalfDivide(int num1)
        {
            total = num1 / 2;
            return total;
        }
        public static int Percent(decimal num1,decimal percent)
        {
            decimal total = num1 * percent;
            return (int)total;
        }
    }
}
