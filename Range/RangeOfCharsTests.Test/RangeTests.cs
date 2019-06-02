using System;
using Xunit;

namespace RangeOfChars
{
    public class RangeTests
    {
        [Fact]
        public void For_ABC_Should_Return_True()
        {
            var digits = new Range('a','f');
            string text = "abc";
            bool actual = digits.Match(text);
            Assert.True(actual);
        }
        [Fact]
        public void For_CBA_Should_Return_True()
        {
            var digits = new Range('a', 'f');
            string text = "abc";
            bool actual = digits.Match(text);
            Assert.True(actual);
        }

        [Fact]
        public void For_gABC_Should_Return_False()
        {
            var digits = new Range('a', 'f');
            string text = "gbcg";
            bool actual = digits.Match(text);
            Assert.False(actual);
        }

        [Fact]
        public void For_1ABC_Should_Return_False()
        {
            var digits = new Range('a', 'f');
            string text = "1abc";
            bool actual = digits.Match(text);
            Assert.False(actual);
        }

        [Fact]
        public void For_Null_String_Should_Return_False()
        {
            var digits = new Range('a', 'f');
            string text = "";
            bool actual = digits.Match(text);
            Assert.False(actual);
        }

        [Fact]
        public void For_Empty_Should_Return_False()
        {
            var digits = new Range('a', 'f');
            string text = " ";
            bool actual = digits.Match(text);
            Assert.False(actual);
        }
        [Fact]
        public void For_A_Space_In_String_Should_Return_False()
        {
            var digits = new Range('a', 'f');
            string text = " abc ";
            bool actual = digits.Match(text);
            Assert.False(actual);
        }
    }
}
