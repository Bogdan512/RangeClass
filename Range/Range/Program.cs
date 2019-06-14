using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            string isTrue = "True";
            string text = "True";
            string substring = text.Substring(0, isTrue.Length);

            Console.WriteLine(substring);
            Console.WriteLine(text.Substring(isTrue.Length));
            //Console.WriteLine(text.Substring(1));
            //Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
