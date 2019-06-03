using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var digit = new Choice
            (
                new Character('0'),
                new Range('1','9')
            );
            bool actual = digit.Match("1024");
            Console.WriteLine(actual);

            Console.Read();
        }
    }
}
