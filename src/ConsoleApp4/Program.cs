using System;
using System.Diagnostics.Metrics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            var text = Console.ReadLine();

            var result = string.Empty;
            foreach (var letter in text)
            {
                if (char.IsUpper(letter) is true)
                {
                    result += char.ToLower(letter);
                }
                else if (char.IsLower(letter) is true)
                {
                    result += char.ToUpper(letter);
                }
                else
                {
                    result += letter;
                }
            }
            
            Console.WriteLine(result);
        }
    }
}
