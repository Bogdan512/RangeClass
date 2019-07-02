using System;

namespace RangeOfChars
{
    public class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number()
        {
            //pattern = new Sequance(
            //        new Optional(new Character('-')),
            //        new Range('1', '9'),
            //        new Many(new Sequance(new Optional(new Character('.')), new Range('0', '9'))));

            pattern = new Sequance(new Range('1', '9'));
            //pattern = new OneOrMore(new Range('1', '9')); //pt 002 si nr de la 1-9 ex 142
            //pattern = new Sequance(new OneOrMore(new Range('1', '9')), new Many(new Range('0', '9')));    //pt 002 si nr de la 1-9 ex 142 si 2041 sau 2004006
            //pattern = new Sequance(new Optional(new Character('-')), new OneOrMore(new Range('1', '9')), new Many(new Range('0', '9'))); pt 002 , 243, 206005 si -254 si -2087
            //pattern = new Sequance(new Optional(new Character('-')), new OneOrMore(new Range('1', '9')), new Optional(new Character('.')), new Many(new Range('0', '9')));
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}