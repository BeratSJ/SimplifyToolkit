namespace SimplifyToolkit
{
    public class SimplifyMath
    {
        public static int total;
        public static int HalfDivide(int num1)
        {
            total = num1 / 2;
            return total;
        }
        public static int Percent(decimal num1, decimal percent)
        {
            decimal total = num1 * percent;
            return (int)total;
        }
        public static int Factorial(int num1)
        {
            int result = 1;
            for (int i = 1; i <= num1; i++)
            {
                result *= i;
            }
            return result; // Added return statement
        }
    }
}
