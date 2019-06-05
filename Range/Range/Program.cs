using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var ab = new Sequance(
                new Character('a'),
                new Character('b')
            );

            IMatch actual = ab.Match("abcd");
            Console.WriteLine(actual.Succes());

            Console.Read();
        }
    }
}
