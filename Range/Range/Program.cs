using System;
using System.IO;

namespace RangeOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = File.ReadAllText(args[0]);
            var value = new Value();
            IMatch result = value.Match(str);
            string testResult = result.RemainingText();
            Console.WriteLine(str + "\n");

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
