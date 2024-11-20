using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            var length = int.Parse(Console.ReadLine());
            var numbersList = FillList(length);
            CheckIfSorted(numbersList);
            DisplayList(numbersList);
        }

        public static List<int> FillList(int length)
        {
            var digits = new List<int>();
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i}: ");
                var addNumber = int.Parse(Console.ReadLine());
                digits.Add(addNumber);
            }
            return digits;
        }

        public static void CheckIfSorted(List<int> numbers)
        {
            var maxElement = numbers.Max();
            var minElement = numbers.Min();
             = maxElement;

        }

        public static void DisplayList(List<int> digits)
        {
            foreach (var digit in digits)
            {
                Console.Write($"{digit} ");
            }
            Console.WriteLine();
        }
    }
}
