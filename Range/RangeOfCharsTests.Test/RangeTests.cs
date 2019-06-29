using System;
using Xunit;

namespace RangeOfChars.Test
{
    public class RangeTests
    {
        [Fact]
        public void For_abc_Should_Return_True_From_Range_a_To_f()
        {
            var digits = new Range('a', 'f');
            string text = "abc";
            IMatch actual = digits.Match(text);
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_abc_Should_Return_bc_From_Range_a_To_f()
        {
            var digits = new Range('a', 'f');
            string text = "abc";
            IMatch actual = digits.Match(text);
            Assert.Equal("bc", actual.RemainingText());
        }

        [Fact]
        public void For_abc_Should_Return_False_From_Range_b_To_f()
        {
            var digits = new Range('b', 'f');
            string text = "abc";
            IMatch actual = digits.Match(text);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_abc_Should_Return_abc_From_Range_b_To_f()
        {
            var digits = new Range('b', 'f');
            string text = "abc";
            IMatch actual = digits.Match(text);
            Assert.Equal("abc", actual.RemainingText());
        }

        [Fact]
        public void For_Empty_String_Should_Return_False()
        {
            var digits = new Range('a', 'f');
            string text = "";
            IMatch actual = digits.Match(text);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Empty_String_Should_Return_Empty_String()
        {
            var digits = new Range('a', 'f');
            string text = "";
            IMatch actual = digits.Match(text);
            Assert.Equal("", actual.RemainingText());
        }

        [Fact]
        public void For_Null_Should_Return_False()
        {
            var digits = new Range('a', 'f');
            string text = null;
            IMatch actual = digits.Match(text);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Null_Should_Return_Null()
        {
            var digits = new Range('a', 'f');
            string text = null;
            IMatch actual = digits.Match(text);
            Assert.Null(actual.RemainingText());
        }
    }

}
