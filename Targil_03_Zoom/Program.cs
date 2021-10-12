using System;

namespace Targil_03_Zoom
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, sum, diff, prod, div;
            Console.WriteLine("Enter 2 integers");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
            sum = num1 + num2;
            diff = num1 - num2;
            prod = num1 * num2;
            div = num1 / num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, diff);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, prod);
            Console.WriteLine("{0} : {1} = {2}", num1, num2, div);

            Console.ReadKey();
        }
    }
}
