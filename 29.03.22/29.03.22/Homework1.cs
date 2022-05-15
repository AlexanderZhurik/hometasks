using System;

namespace Homework1
{
    static class Homework1
    {
        static public void sumOfDigits(int num)
        {
            Console.WriteLine("First task");
            Console.WriteLine($"Sum of digits from the number {num} is {(num / 100) + (num % 100 / 10) + (num % 10)}");
        }
        static public void IsPointInCircle()
        {
            Console.WriteLine("\n\nSecond task");
            int r = 5;
            Console.WriteLine("Enter x1 value");
            if (Int32.TryParse(Console.ReadLine(), out int x1))
            {
                Console.WriteLine("Enter y1 value");
                if (Int32.TryParse(Console.ReadLine(), out int y1))
                {
                    if (x1 < r && x1 > -r && y1 < r && y1 > -r) { Console.WriteLine($"Point is inside the circle with radius {r}."); }
                    else { Console.WriteLine("Point is outside the circle."); }
                }
                else { Console.WriteLine("Invalid input."); }
            }
            else { Console.WriteLine("Invalid input."); }
        }
        static public void IsMidDigitLarger()
        {
            Console.WriteLine("\n\nTrird task");
            Console.WriteLine("Enter 3-digit number");
            if (Int32.TryParse(Console.ReadLine(), out int task3))
            {
                int task3MidDigit = task3 % 100 / 10;
                if (task3MidDigit <= task3 / 100 && task3MidDigit > task3 % 10) { Console.WriteLine(true); }
                else { Console.WriteLine(false); }
            }
            else { Console.WriteLine("Invalid input."); }
        }
        static public void ChangeOutDigits()
        {
            Console.WriteLine("\n\nFourth task");
            Console.WriteLine("Enter 3-digit number");
            if (Int32.TryParse(Console.ReadLine(), out int task4))
            {
                Console.WriteLine((task4 % 10) * 100 + (task4 % 100 / 10) * 10 + (task4 / 100));
            }
            else { Console.WriteLine("Invalid input."); }
        }
        static public void isInteger()
        {
            Console.WriteLine("\n\nFifth task");
            if (Double.TryParse(Console.ReadLine(), out double task5))
            {
                Console.WriteLine(task5 == Math.Floor(task5));

            }
            else { Console.WriteLine("Invalid input."); }
        }
    }
}