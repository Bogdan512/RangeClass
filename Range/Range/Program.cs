using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1,2,3");
            Console.WriteLine(actual.Succes());
            Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
