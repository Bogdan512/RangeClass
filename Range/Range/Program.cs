using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            var number = new Number();
            IMatch actual = number.Match("2");
            Console.WriteLine(actual.Succes());
            Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
