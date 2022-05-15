using System;
using Homework1;
using Homework2;
using Homework3;
using Homework4;
using Homework5;
namespace _29._03._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework nubmer 1:");
            Homework1.Homework1.sumOfDigits(465);
            Homework1.Homework1.IsPointInCircle();
            Homework1.Homework1.IsMidDigitLarger();
            Homework1.Homework1.ChangeOutDigits();
            Homework1.Homework1.isInteger();
            Console.WriteLine("\n\n------------------------------------");
            Console.WriteLine("Homework nubmer 2:");
            Homework2.Homework2.DoMathOperations();
            Homework2.Homework2.CheckTheQuarter();
            Homework2.Homework2.InAscendingOrder();
            Homework2.Homework2.SolveSquareEquation();
            Homework2.Homework2.WriteTheNumber();
            Homework2.Homework2.DoesTriangleExist();
            Console.WriteLine("\n\n------------------------------------");
            Console.WriteLine("Homework nubmer 3:");
            Homework3.Homework3.DivisibleByA();
            Homework3.Homework3.SquareLessThanA();
            Homework3.Homework3.LargestDivisorOfA();
            Homework3.Homework3.IsDivisibleBySeven();
            Homework3.Homework3.BiggestDivisor();
            Homework3.Homework3.NubmerOfOddDigits();
            Homework3.Homework3.MirrorTheNumber();
            Console.WriteLine("\n\n------------------------------------");
            Console.WriteLine("Homework nubmer 4:");
            Homework4.Homework4.EvenOddCount();
            Homework4.Homework4.ReplaceWithSumOfTwo();
            Homework4.Homework4.JoinTwoArrays();
            Homework4.Homework4.ChangePartsOfArray();
            Homework4.Homework4.MoveTheArray();
            Homework4.Homework4.ChangeEvenOdd();
            Homework4.Homework4.MinAndSumAfterZero();
            Homework4.Homework4.SortByInsert();
            Console.WriteLine("\n\n------------------------------------");
            Console.WriteLine("Homework nubmer 5:");
            Homework5.Homework5.CnangeSignOfOuterElements();
            Homework5.Homework5.GenerateMultiplicationTable();
            Homework5.Homework5.GenerateChessBoard();
            Homework5.Homework5.IsCovidSafe();
            Homework5.Homework5.SumMidMinMaxRevenue();
            Homework5.Homework5.DrawAHourglass();
        }
    }
}
