using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            string accepted = "eE";
            string text = "ea";
            int index = accepted.IndexOf(text[0]);

            Console.WriteLine(index);
            Console.WriteLine(text.Substring(1));
            //Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
