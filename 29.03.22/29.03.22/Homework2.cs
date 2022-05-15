using System;

namespace Homework2
{
    static class Homework2
    {
        static public void DoMathOperations()
        {
            Console.WriteLine("First task");
            Console.WriteLine("Enter two numbers");
            if (int.TryParse(Console.ReadLine(), out int task1_A) && int.TryParse(Console.ReadLine(), out int task1_B))
            {
                if (task1_A > task1_B) { Console.WriteLine($"{task1_A} + {task1_B} = {task1_A + task1_B}"); }
                else if (task1_A == task1_B) { Console.WriteLine($"{task1_A} * {task1_B} = {task1_A * task1_B}"); }
                else { Console.WriteLine($"{task1_A} - {task1_B} = {task1_A - task1_B}"); }
            }
            else Console.WriteLine("Invalid input.");
        }
        static public void CheckTheQuarter()
        {

            Console.WriteLine("\n\nSecond task");
            Console.WriteLine("Enter coordinates of the point");
            if (int.TryParse(Console.ReadLine(), out int task2_x) && int.TryParse(Console.ReadLine(), out int task2_y))
            {
                if (task2_x == 0 || task2_y == 0) { Console.WriteLine("The point is on one of the coordinate axes"); }
                else if (task2_x > 0)
                {
                    if (task2_y > 0) { Console.WriteLine("The point is in 1st quarter"); }
                    else { Console.WriteLine("The point is in 2nd quarter"); }
                }
                else
                {
                    if (task2_y < 0) { Console.WriteLine("The point is in 3rd quarter"); }
                    else { Console.WriteLine("The point is in 4th quarter"); }
                }
            }
            else Console.WriteLine("Invalid input.");

        }
        static public void InAscendingOrder()
        {
            Console.WriteLine("\n\nThird task");
            Console.WriteLine("Enter three numbers");
            if (int.TryParse(Console.ReadLine(), out int task3_1) &&
                int.TryParse(Console.ReadLine(), out int task3_2) &&
                int.TryParse(Console.ReadLine(), out int task3_3))
            {
                Console.WriteLine($"{Math.Max(task3_3, Math.Max(task3_1, task3_2))}, {task3_1 + task3_2 + task3_3 - Math.Max(task3_3, Math.Max(task3_1, task3_2)) - Math.Min(task3_3, Math.Min(task3_1, task3_2))}, {Math.Min(task3_3, Math.Min(task3_1, task3_2))}");
            }
            else { Console.WriteLine("Invalid input."); }
        }
        static public void SolveSquareEquation()
        {
            Console.WriteLine("\n\nFourth task");
            Console.WriteLine("Enter A, B & C");
            if (int.TryParse(Console.ReadLine(), out int task4_A) && int.TryParse(Console.ReadLine(), out int task4_B) && int.TryParse(Console.ReadLine(), out int task4_C))
            {
                double task4_D = Math.Pow(task4_B, 2) - 4 * task4_A * task4_C;
                if (task4_D == 0) { Console.WriteLine(-task4_B / (2 * task4_A)); }
                else if (task4_D > 0) { Console.WriteLine($"{(-task4_B - Math.Sqrt(task4_D)) / (2 * task4_A)}, {(-task4_B + Math.Sqrt(task4_D)) / (2 * task4_A)}"); }
                else { Console.WriteLine("No roots"); }
            }
            else { Console.WriteLine("Invalid input."); }
        }
        static public void WriteTheNumber()
        {
            Console.WriteLine("\n\nFifth task");
            Console.WriteLine("Enter a number");
            if (int.TryParse(Console.ReadLine(), out int task5))
            {
                if (task5 < 20 && task5 >= 10)
                {
                    switch (task5)
                    {
                        case 10:
                            Console.WriteLine("десять");
                            break;
                        case 11:
                            Console.WriteLine("одиннадцать");
                            break;
                        case 12:
                            Console.WriteLine("двенадцать");
                            break;
                        case 13:
                            Console.WriteLine("тринадцать");
                            break;
                        case 14:
                            Console.WriteLine("четырнадцать");
                            break;
                        case 15:
                            Console.WriteLine("пятнадцать");
                            break;
                        case 16:
                            Console.WriteLine("шестнадцать");
                            break;
                        case 17:
                            Console.WriteLine("семнадцать");
                            break;
                        case 18:
                            Console.WriteLine("восемнадцать");
                            break;
                        case 19:
                            Console.WriteLine("девятнадцать");
                            break;

                    }
                }
                else if (task5 < 100 && task5 > 0)
                {
                    switch (task5 / 10)
                    {
                        case 2:
                            Console.Write("двадцать ");
                            break;
                        case 3:
                            Console.Write("тридцать ");
                            break;
                        case 4:
                            Console.Write("сорок ");
                            break;
                        case 5:
                            Console.Write("пятьдесят ");
                            break;
                        case 6:
                            Console.Write("шестьдесят ");
                            break;
                        case 7:
                            Console.Write("семьдесят ");
                            break;
                        case 8:
                            Console.Write("восемьдесят ");
                            break;
                        case 9:
                            Console.Write("девяносто ");
                            break;
                    }
                    switch (task5 % 10)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.Write("один");
                            break;
                        case 2:
                            Console.Write("два");
                            break;
                        case 3:
                            Console.Write("три");
                            break;
                        case 4:
                            Console.Write("четыре");
                            break;
                        case 5:
                            Console.Write("пять");
                            break;
                        case 6:
                            Console.Write("шесть");
                            break;
                        case 7:
                            Console.Write("семь");
                            break;
                        case 8:
                            Console.Write("восемь");
                            break;
                        case 9:
                            Console.Write("девять");
                            break;
                    }
                    Console.WriteLine();

                }
                else { Console.WriteLine("Number must be more than 0 and less than 100"); }

            }
            else { Console.WriteLine("Invalid input."); }
        }
        static public void DoesTriangleExist()
        {
            Console.WriteLine("\n\nSixth task");
            Console.WriteLine("Enter sides of triangle");
            if (int.TryParse(Console.ReadLine(), out int task6_A) && int.TryParse(Console.ReadLine(), out int task6_B) && int.TryParse(Console.ReadLine(), out int task6_C))
            {
                if (task6_A + task6_B > task6_C && task6_B + task6_C > task6_A && task6_A + task6_C > task6_B) { Console.WriteLine("Triangle exists"); }
                else { Console.WriteLine("Triangle does not exist"); }
            }
        }
    }
   
}
