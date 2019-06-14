using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            string isFalse = "false";
            string text = "true";
            string substring = text.Substring(0, isFalse.Length);

            Console.WriteLine(substring);
            Console.WriteLine(text.Substring(isFalse.Length));
            //Console.WriteLine(text.Substring(1));
            //Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
