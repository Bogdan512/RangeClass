using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            var number = new Number(new Range('0', '9'));
            IMatch actual = number.Match("2");
            Console.WriteLine(actual.Succes());
            Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
