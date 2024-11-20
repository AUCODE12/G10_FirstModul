namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            var text = Console.ReadLine();
            string result;

            FindLongestWord(text, out result);
            Console.WriteLine(result);
        }

        public static void FindLongestWord(string publicText, out string response)
        {
            string[] words = publicText.Split(' ');
            response = words[0];
            for (int i = 1; i < words.Length; i++)
            { 
                 if (response.Length < words[i].Length)
                {
                    response = words[i];
                }
            }
        }
    }
}
