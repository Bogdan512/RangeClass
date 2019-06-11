using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            var ab = new Sequance(
            new Character('a'),
            new Character('b'));

            var abc = new Sequance(
            ab,
            new Character('c'));

            IMatch actual = abc.Match("ax");
            Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
