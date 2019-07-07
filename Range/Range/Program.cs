using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            var number = new Number();
            IMatch actual = number.Match("12.123E-3");
            Console.WriteLine(actual.Succes());
            Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
