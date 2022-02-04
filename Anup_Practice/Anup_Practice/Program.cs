using System;

namespace Anup_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, Sum,mul,sub,div;
            Console.WriteLine("Enter First No:-");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second No:-");
            b = Convert.ToInt32(Console.ReadLine());
            Sum = a + b;
            Console.WriteLine("Sum of No:-" + Sum);
            mul = a * b;
            Console.WriteLine("Multiply of No:-"+mul);
            sub = a - b;
            Console.WriteLine("Subtraction of No:-"+sub);
            div = a / b;
            Console.WriteLine("Division of No:-"+div);
        }
    }
}
