using System;

namespace _22._03._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first task");
            int[,] task1 = new int[,] {
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 } 
        };
        for(int i = 1; i < task1.GetLength(0) - 1; i++)
            {
                task1[i, 0] *= -1;
                task1[i, task1.GetLength(1) -1] *= -1;
            }
        
        for (int i = 0; i< task1.GetLength(1); i++)
            {
                task1[0, i] *= -1;
                task1[task1.GetLength(0) - 1, i] *= -1;
            }
        for (int i = 0; i < task1.GetLength(0); i++)
            {
                for (int j = 0; j < task1.GetLength(1); j++)
                {
                    Console.Write("{0}\t", task1[i, j]);
                }
                Console.WriteLine();
            }



            Console.WriteLine("\n\nSecond task");
            int[,] task2 = new int[9,9];
            for (int i = 0; i < 9; i++)
            {
                task2[0, i] = i+1;
                task2[i, 0] = i+1;
            }
            for( int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    task2[i, j] = task2[0, j] * task2[i, 0];
                    
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("{0}\t", task2[i, j]);
                }
                Console.WriteLine();
            }



            Console.WriteLine("\n\nTrird task");
            Console.WriteLine("enter the size of matrix");
            int[,] task3 = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
            // нужно ли делать безопасный парсинг каждый раз, или в учебных целях можно и опасный?
            // очень загромождает программу просто
            int first;
            if (task3.GetLength(0) % 2 != 0 ^ task3.GetLength(1) % 2 != 0) { first = 1; }
            else { first = 0; }
            task3[0, 0] = first;
            for (int i = 0; i < task3.GetLength(0); i++)
            {
                if (i != 0)
                {
                    task3[i, 0] = task3[i - 1, 0] == 0 ? 1 : 0;
                }
                for (int j = 0; j < task3.GetLength(1) -1 ; j++)
                {
                    task3[i, j + 1] = task3[i, j] == 0 ? 1 : 0;
                }
                
            }
            for (int i = 0; i < task3.GetLength(0); i++)
            {
                
                for (int j = 0; j < task3.GetLength(1); j++)
                {
                    Console.Write($"{task3[i, j] } ");
                }
                Console.WriteLine();
            }




            Console.WriteLine("\n\nFourth task");
            int[,] task4 = new int[,]
            {
                { 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                { 1, 0, 1, 0, 1, 0, 1, 1, 0 }, // на этой строчке две единицы подряд
                { 0, 0, 0, 1, 0, 1, 0, 1, 0 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            bool flag = false;
            for (int i = 0; i < task4.GetLength(0); i++)
                
            {
                if (flag) { break; }
                for (int j = 0; j < task4.GetLength(1); j++)
                {
                    if (j != task4.GetLength(1) - 1 && task4[i, j] == task4[i, j + 1] && task4[i, j] == 1)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            Console.WriteLine(!flag ? "Place is covid-safe" : "Plase isn't covid-safe");




            Console.WriteLine("\n\nFifth task");
            Random rnd = new Random();
            double[,] task5 = new double[10, 6];
            for(int i = 0; i < task5.GetLength(0); i++)
            {
                for (int j = 0; j < task5.GetLength(1); j++)
                {
                    task5[i, j] = rnd.NextDouble() * 1000;
                }
            }
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{task5[i, j]:f1}\t");
                }
                Console.WriteLine();
            }

            double task5_min = double.MaxValue;
            double task5_max = double.MinValue;
            for (int i = 0; i < task5.GetLength(0); i++)
            {
                double cur = 0;
                for (int j = 0; j < task5.GetLength(1); j++)
                {
                    if (task5[i, j] < task5_min) { task5_min = task5[i, j]; }
                    if (task5[i, j] > task5_max) { task5_max = task5[i, j]; }
                    cur += task5[i, j];
                }
                Console.WriteLine($"Shop number {i+1}: {cur:f1}");
            }
            for (int j = 0; j < task5.GetLength(1); j++)
            {
                double cur = 0;
                for (int i = 0; i < task5.GetLength(0); i++)
                {
                    cur += task5[i, j];
                }
                Console.WriteLine($"Month nubmer {j+1}: {cur / 10:f1}");
            }
            Console.WriteLine($"Minimal income: {task5_min:f1}, maximal income: {task5_max:f1}");





            Console.WriteLine("\n\nSixth task");
            char[,] task6 = new char[7, 7];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    task6[i, j] = '0';
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = i; j < 7 - i; j++)
                { 
                    task6[i, j] = '1';
                    task6[6 - i, j] = '1';
                }
                    
            }
            for (int i = 0; i < 7; i++)
            {

                for (int j = 0; j < 7; j++)
                {
                    Console.Write($"{task6[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

