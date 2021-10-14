using System;

namespace Targil_04_Zoom
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, hours, minutes, seconds;
            Console.WriteLine("Enter num of seconds");
            num = int.Parse(Console.ReadLine());
            hours = num / 3600;
            minutes = num % 3600 / 60;
            seconds = num % 60;
            Console.WriteLine("{0} seconds are {1} hours, {2} minutes and {3} seconds", num, hours, minutes, seconds);

            Console.ReadKey();
        }
    }
}

