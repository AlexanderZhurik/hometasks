using System;

namespace _15._03._22
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("First task");
            Console.WriteLine("Enter the number");
            if (int.TryParse(Console.ReadLine(), out int task1))
            {
                for (int i = task1; i <= 1000; i += task1) { Console.WriteLine(i); }
            }



            Console.WriteLine("\n\nSecond task");
            Console.WriteLine("Enter the number");
            if (int.TryParse(Console.ReadLine(), out int task2))
            {
                for (int i = 1; i <= task2; i++)
                {
                    if (i * i < task2) Console.WriteLine(i);
                    else break;

                }
            }



            Console.WriteLine("\n\nThird task");
            Console.WriteLine("Enter the number");
            if (int.TryParse(Console.ReadLine(), out int task3))
            {
                for (int i = task3 - 1; i > 0; i--)
                {
                    if (task3 % i == 0) { Console.WriteLine(i); break; }
                }
            }




            Console.WriteLine("\n\nFourth task");
            Console.WriteLine("Enter A and B");
            if (int.TryParse(Console.ReadLine(), out int task4_A) && int.TryParse(Console.ReadLine(), out int task4_B))
            {
                if (task4_A < task4_B)
                {
                    for (int i = task4_A; i <= task4_B; i++) { if (i % 7 == 0) Console.WriteLine(i); }
                }
                else for (int i = task4_B; i <= task4_A; i++) { if (i % 7 == 0) Console.WriteLine(i); }
            }





            Console.WriteLine("\n\nFifth task");
            Console.WriteLine("Enter two numbers");
            if (int.TryParse(Console.ReadLine(), out int task5_1) && int.TryParse(Console.ReadLine(), out int task5_2))
            {
                while (task5_1 != 0 && task5_2 != 0)
                {
                    if (task5_1 > task5_2) { task5_1 %= task5_2; }
                    else { task5_2 %= task5_1; }
                }
                Console.WriteLine(task5_1 + task5_2);
            }





            //Console.WriteLine("\n\nSixth task");




            Console.WriteLine("\n\nSeventh task");
            Console.WriteLine("Enter the number");

            if (int.TryParse(Console.ReadLine(), out int task7))
            {
                int oddCnt = 0;
                for (int i = 9; i > 0; i--)
                {
                    if (Math.Floor(task7 % Math.Pow(10, i) / Math.Pow(10, i-1)) % 2 != 0) { oddCnt++; }  
                }
                Console.WriteLine(oddCnt);
            }





            Console.WriteLine("\n\nEighth task");
            if (int.TryParse(Console.ReadLine(), out int task8))
            {
                int task8Num = task8;
                int task8Counter = 0;
                while (task8Num > 0) 
                {
                    task8Counter++;
                    task8Num /= 10;
                }
                for (int i = 1; i <= task8Counter; i++)
                {
                    Console.Write(Math.Floor(task8 % Math.Pow(10, i) / Math.Pow(10, i - 1)));
                }
            }





        }
    }
}
