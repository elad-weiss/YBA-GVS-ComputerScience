using System;

namespace Targil_02_Zoom
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int sum;
            Console.WriteLine("Enter 2 numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
            Console.ReadKey();
        }
    }
}
