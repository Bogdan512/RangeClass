using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class ListTests
    {
        [Fact]
        public void It_Should_Consume_A_Pattern_Returning_True()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void It_Should_Consume_A_Pattern_Returning_EmptyString()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void It_Should_Consume_A_Pattern_And_A_Character_With_RemainingText_Empty()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1,");
            Assert.Equal(",", actual.RemainingText());
        }

        [Fact]
        public void It_Should_Consume_All_The_Patterns_And_Characters_Returning_True()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1,2,3");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void It_Should_Consume_All_The_Patterns_And_Characters_With_RemainingText_Empty()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1,2,3");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void It_Should_Consume_All_The_Patterns_And_Characters_Except_Last_Coma_Returning_True()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1,2,3,");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void It_Should_Consume_All_The_Patterns_And_Characters_Returning_A_Coma()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1,2,3,");
            Assert.Equal(",", actual.RemainingText());
        }

        [Fact]
        public void For_String_1a_It_Should_Consume_Only_The_1_And_Return_True()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1a");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_String_1a_It_Should_Consume_Only_The_1_And_Return_a()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1a");
            Assert.Equal("a", actual.RemainingText());
        }

        [Fact]
        public void For_Empty_String_It_Should_Return_Empty_String()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match(string.Empty);
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Empty_String_It_Should_Return_True()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match(string.Empty);
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Digits_Separators_NewLine_And_Tab_Should_Return_Empty_String()
        {
            var digits = new OneOrMore(new Range('0', '9'));
            var whitespace = new Many(new Any(" \r\n\t"));
            var separator = new Sequance(whitespace, new Character(';'), whitespace);
            var list = new List(digits, separator);

            IMatch actual = list.Match("1; 22  ;\n 333 \t; 22");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Number_And_NewLine_Should_Return_NewLine()
        {
            var digits = new OneOrMore(new Range('0', '9'));
            var whitespace = new Many(new Any(" \r\n\t"));
            var separator = new Sequance(whitespace, new Character(';'), whitespace);
            var list = new List(digits, separator);

            IMatch actual = list.Match("1 \n");
            Assert.Equal(" \n", actual.RemainingText());
        }

        [Fact]
        public void For_String_abc_Should_Return_abc()
        {
            var digits = new OneOrMore(new Range('0', '9'));
            var whitespace = new Many(new Any(" \r\n\t"));
            var separator = new Sequance(whitespace, new Character(';'), whitespace);
            var list = new List(digits, separator);

            IMatch actual = list.Match("abc");
            Assert.Equal("abc", actual.RemainingText());
        }

        [Fact]
        public void For_null_It_Should_Return_null()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match(null);
            Assert.Equal(null, actual.RemainingText());
        }

        [Fact]
        public void For_null_It_Should_Return_true()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match(null);
            Assert.True(actual.Succes());
        }
    }
}
