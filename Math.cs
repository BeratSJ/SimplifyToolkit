namespace SimplifyToolkit
{
    public class Math
    {
        public static int total;

        //public static int Addition(int num1, int num2)
        // {
        //    total = num1 + num2;
        //    return total;
        // }

        //public static int Subtraction(int num1,int num2)
        //{
        //    total = num1 - num2;
        //    return total;
        //}

        //public static int Multiplication(int num1, int num2)
        //{ 
        //    total = num1 * num2;
        //    return total; 
        //}

        //public static int Divide(int num1, int num2)
        //{
        //    total = num1 / num2;
        //    return total;
        //}

        public static int NumberDouble(int num1)
        {
            total = num1 * 2;
            return total;
        }

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
