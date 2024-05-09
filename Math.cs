public static void Addition(int num1,int num2,bool isConsole)
{
    int total = num1 + num2;
    if (isConsole)
    {
        Console.WriteLine(total);
    }else
    {
        return total;
    }

}
