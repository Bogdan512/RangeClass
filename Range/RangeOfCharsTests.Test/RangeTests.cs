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
        public void For_IPattern_Range_0_9_4_And_String_45_Should_Return_False()
        {
            var digits = new Range('0', '9', "4");
            IMatch actual = digits.Match("45");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_IPattern_Range_0_9_4_And_String_45_Should_Return_45()
        {
            var digits = new Range('0', '9', "4");
            IMatch actual = digits.Match("45");
            Assert.Equal("45", actual.RemainingText());
        }

        [Fact]
        public void For_IPattern_Range_0_9_4_And_String_54_Should_Return_True()
        {
            var digits = new Range('0', '9', "4");
            IMatch actual = digits.Match("54");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_IPattern_Range_0_9_4_And_String_54_Should_Return_4()
        {
            var digits = new Range('0', '9', "4");
            IMatch actual = digits.Match("54");
            Assert.Equal("4", actual.RemainingText());
        }

        [Fact]
        public void For_IPattern_Range_0_9_426_And_String_245_Should_Return_False()
        {
            var digits = new Range('0', '9', "426");
            IMatch actual = digits.Match("245");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_IPattern_Range_0_9_426_And_String_245_Should_Return_245()
        {
            var digits = new Range('0', '9', "426");
            IMatch actual = digits.Match("245");
            Assert.Equal("245", actual.RemainingText());
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
