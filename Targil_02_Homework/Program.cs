using System;

namespace Targil_02_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*הייתי יכול לשים ביטויים נוספים מבדיקת המשולשים בתוך משתנים בוליאנים
            אבל הגלל שרוב הביטויים מופעים רק פעם אחת לא הכנסתי אותם לתוך
            משתנים בוליאנים כדי לחסוך בזיכרון
            */

            Console.WriteLine("Please enter 3 numbers:");
            double side1, side2, side3, biggestSide, abSum, abMultiply;
            side1 = Double.Parse(Console.ReadLine());
            side2 = Double.Parse(Console.ReadLine());
            side3 = Double.Parse(Console.ReadLine());

            //משתנה שמכיל את הצלע הכי גדולה משלושת הצלעות שהכניס המשתמש
            biggestSide = Math.Max(side1, Math.Max(side2, side3));

            //סכום שתי הצלעות הקטנות במשולש
            abSum = side1 + side2 + side3 - biggestSide;

            //מכפלת שתי הצלעות הקטנות
            abMultiply = (side1 * side2 * side3) / biggestSide;

            //בדיקה שמדובר במשולש חוקי - במשולש חוקי סכום שתי הצלעות הקטנות יותר גדול מהצלע השלישית
            if (biggestSide < abSum)
            {
                //משתנה בלויאני שבודק האם המשולש ישר זווית על ידי שימוש במשפט פיתגורס
                bool isRightAngle = (Math.Pow(abSum, 2.0) - 2 * abMultiply == Math.Pow(biggestSide, 2.0));

                // בדיקה אם זהו משולש ישר זווית, בו כל הצלעות שוות
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("C");
                }

                //בדיקה אם זהו משולש שווה שוקיים
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                {
                    //בודק האם המשולש שווה השוקיים הוא גם ישר זווית
                    if (isRightAngle)
                    {
                        Console.WriteLine("E");
                    }
                    else
                    {
                        Console.WriteLine("B");
                    }
                }

                //בודק האם המשולש ישר זווית
                else if (isRightAngle)
                {
                    Console.WriteLine("D");
                }

                //במקרה וכל התנאים לעיל לא מתקיימים אזי המשולש הוא משולש לא מיוחד
                else
                {
                    Console.WriteLine("A");
                }
            }

            //במקרה והצלעות לא מקיימות את אי שוויום המשולשים הם לא יוצרות משולש
            else
            {
                Console.WriteLine("F");
            }

            Console.ReadKey();
        }
    }
}
