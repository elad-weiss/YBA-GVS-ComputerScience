using System;

namespace Targil_05_Zoom
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, dig100, dig10, dig1, newNum;
            Console.WriteLine("Enter 3 digit number");
            num = int.Parse(Console.ReadLine());
            dig100 = num / 100;
            dig10 = num % 100 / 10;
            dig1 = num % 10;
            newNum = dig1 * 100 + dig10 * 10 + dig100;

            Console.WriteLine("new num : {0}", newNum);
            Console.ReadKey();
        }
    }
}
