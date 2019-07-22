using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            var c = new Character('"');
            IMatch actual = c.Match("\"");
            Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
