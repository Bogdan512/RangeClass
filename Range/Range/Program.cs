using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character('b');
            string text = "abc";
            IMatch actual = character.Match(text);
            Console.WriteLine(actual.Succes());

            Console.Read();
        }
    }
}
