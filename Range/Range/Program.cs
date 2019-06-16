using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            var a = new Many(new Character('a'));
            IMatch actual = a.Match("abc");
            //Console.WriteLine(text.Substring(1));
            Console.WriteLine(actual.Succes());
            Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
