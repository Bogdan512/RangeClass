using System;
using System.IO;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            var json = File.ReadAllText(@"D:\Repositories\Example2JSON.json");
            var value = new Value();
            IMatch result = value.Match(json);
            string testResult = result.RemainingText();
            Console.WriteLine(json + "\n");

            if (result.RemainingText() == string.Empty)
            {
                Console.WriteLine("Valid Json");
            }
            else
            {
                Console.WriteLine("Not Valid Json");
            }

            Console.Read();
        }
    }
}
