using System;

namespace Homework4
{
    static class Homework4
    {
        static int[] task1 = new int[] { 3, 38, -4, 0, 324, 84, 57, 79, 321 };
            static int[] task2 = new int[] { -255, 215, -133, -142, -428, -20, -39, 438, 274 };
        static public void EvenOddCount()
            {
            
                Console.WriteLine("First task");
                Console.WriteLine("Array: " + string.Join(" ", task1));


                int EvenCnt = 0, OddCnt = 0;
                for (int i = 0; i < task1.Length; i++)
                {
                    if (task1[i] % 2 == 0) EvenCnt++;
                    else OddCnt++;
                }
                Console.WriteLine($"Count of even numbers: {EvenCnt}, count of odd numbers: {OddCnt}");
            }
        static public void ReplaceWithSumOfTwo()
        {
            
            Console.WriteLine("\n\nSecond task");
            Console.WriteLine("Array: " + string.Join(" ", task2));
            for (int i = 2; i < task2.Length; i += 3)
            {
                task2[i] = task2[i - 1] + task2[i - 2];
            }
            Console.WriteLine(string.Join(" ", task2));
        }
        static public void JoinTwoArrays()
        {
            Console.WriteLine("\n\nThird task");
            int[] task3 = new int[task1.Length + task2.Length];
            for (int i = 0; i < task1.Length; i++) { task3[i] = task1[i]; }
            for (int i = 0; i < task2.Length; i++) { task3[i + task1.Length] = task2[i]; }
            Console.WriteLine(string.Join(" ", task3));
        }
        static public void ChangePartsOfArray()
        {
            Console.WriteLine("\n\nFourth task");
            int[] task4 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Array: " + string.Join(" ", task4));
            int[] task4_tmp = new int[task4.Length];
            if (task4.Length % 2 == 0)
            {
                for (int i = 0; i < task4.Length / 2; i++)
                {
                    task4_tmp[i + task4.Length / 2] = task4[i];
                }
            }
            else
            {
                for (int i = 0; i < task4.Length / 2; i++)
                {
                    task4_tmp[i + task4.Length / 2 + 1] = task4[i];
                }
            }
            for (int i = task4.Length / 2; i < task4.Length; i++)
            {
                task4_tmp[i - task4.Length / 2] = task4[i];
            }
            task4 = task4_tmp;
            Console.WriteLine(string.Join(" ", task4));
        }
        static public void  MoveTheArray()
        {
            Console.WriteLine("\n\nFifth task");
            int[] task5 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array: " + string.Join(" ", task5));
            int task5_tmp = task5[0];
            for (int i = 0; i < task5.Length - 1; i++) { task5[i] = task5[i + 1]; }
            task5[task5.Length - 1] = task5_tmp;
            Console.WriteLine(string.Join(" ", task5));
            Console.WriteLine("Enter N");
            if (int.TryParse(Console.ReadLine(), out int task5_N))
            {
                for (int i = 0; i < task5_N; i++)
                {
                    int task5_tmpN = task5[task5.Length - 1];
                    for (int j = task5.Length - 1; j > 0; j--) { task5[j] = task5[j - 1]; }
                    task5[0] = task5_tmpN;
                }
            }
            Console.WriteLine(string.Join(" ", task5));
        }
        static public void ChangeEvenOdd()
        {
            Console.WriteLine("\n\nSixth task");
            int[] task6 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Array: " + string.Join(" ", task6));
            int tmp = 0;
            for (int i = 0; i < task6.Length - 1; i += 2)
            {
                tmp = task6[i];
                task6[i] = task6[i + 1];
                task6[i + 1] = tmp;
            }
            Console.WriteLine(string.Join(" ", task6));
        }
        static public void MinAndSumAfterZero()
        {
            Console.WriteLine("\n\nSeventh task");
            int[] task7 = new int[] { 2, -6, 324, 0, 5, -28, 156 };
            Console.WriteLine("Array: " + string.Join(" ", task7));
            int task7_min = int.MaxValue;
            bool task7_flag = false;
            int task7_sum = 0;
            for (int i = 0; i < task7.Length; i++)
            {
                if (task7_min > Math.Abs(task7[i])) { task7_min = Math.Abs(task7[i]); }
                if (task7_flag) { task7_sum += task7[i]; }
                else if (task7[i] == 0) { task7_flag = true; }
            }
            Console.WriteLine($"Minimal element: {task7_min}, sum of all elements after 0: {task7_sum}.");
        }
        static public void SortByInsert()
        {
            Console.WriteLine("\n\nEighth task");
            int[] task8 = new int[] { 7, 3, 1, 4, 5, 9, 2, 6, 8 };
            Console.WriteLine("Array: " + string.Join(" ", task8));
            int index;
            int task8_cur;
            for (int i = 0; i < task8.Length; i++)
            {
                index = i;
                task8_cur = task8[i];
                while (index > 0 && task8_cur < task8[index - 1])
                {
                    task8[index] = task8[index - 1];
                    index--;
                }
                task8[index] = task8_cur;
            }
            Console.WriteLine(string.Join(" ", task8));

        }
    } 
    }
  

