namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            var text = Console.ReadLine();

            Console.Write(withoutX(text));
        }
        public static string withoutX(string text)
        {
            if (text.StartsWith('x') is true)
            {
                return text.Substring(1);
            }
            else if (text.EndsWith('x') is true)
            {
                return text.Substring(0, text.Length - 1);
            }
            else
            {
                return text;
            }
        }
    }
}