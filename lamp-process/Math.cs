using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;

namespace lamp_process
{
    public class Math
    {
        public static int total;

        public static int Addition(int num1, int num2)
         {
            total = num1 + num2;
            return total;
         }

        public static int Subtraction(int num1,int num2)
        {
            total = num1 - num2;
            return total;
        }

        public static int Multiplication(int num1, int num2)
        { 
            total = num1 * num2;
            return total; 
        }

        public static int Divide(int num1, int num2)
        {
            total = num1 / num2;
            return total;
        }

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
    }
}
