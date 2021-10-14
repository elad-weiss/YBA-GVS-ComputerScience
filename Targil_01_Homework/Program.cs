using System;

namespace Targil_01_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //the first part gets a four digit number from the user
            Console.WriteLine("Enter a 4 digit number");
            int num, dig1, dig2, dig3, dig4, newNum, sum, prod;
            num = int.Parse(Console.ReadLine());
            //this part splits the four digit number to each of its digits
            dig1 = num / 1000;
            dig2 = num / 100 % 10;
            dig3 = num % 100 / 10;
            dig4 = num % 10;
            //this part uses the digits to get the ansers for the questions
            sum = dig1 + dig2 + dig3 + dig4;
            prod = dig1 * dig2 * dig3 * dig4;
            newNum = dig4 * 1000 + dig3 * 100 + dig2 * 10 + dig1;

            //this part print the answers
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", dig1, dig2, dig3, dig4, sum);
            Console.WriteLine("{0} * {1} * {2} * {3} = {4}", dig1, dig2, dig3, dig4, prod);
            Console.WriteLine("the inverse of {0} is {1}", num, newNum);
        }
    }
}
