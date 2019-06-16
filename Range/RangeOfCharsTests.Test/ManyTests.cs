using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class ManyTests
    {
        [Fact]
        public void For_IPattern_Char_a_And_String_abc_Should_Return_True()
        {
            var a = new Many(new Character('a'));
            IMatch actual = a.Match("abc");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_IPattern_Char_a_And_String_abc_Should_Return_String_bc()
        {
            var a = new Many(new Character('a'));
            IMatch actual = a.Match("abc");
            Assert.Equal("bc", actual.RemainingText());
        }

        [Fact]
        public void For_IPattern_Char_a_And_String_aaaabc_Should_Return_True()
        {
            var a = new Many(new Character('a'));
            IMatch actual = a.Match("aaaabc");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_IPattern_Char_a_And_String_aaaabc_Should_Return_String_bc()
        {
            var a = new Many(new Character('a'));
            IMatch actual = a.Match("aaaabc");
            Assert.Equal("bc", actual.RemainingText());
        }

        [Fact]
        public void For_IPattern_Char_a_And_String_bc_Should_Return_True()
        {
            var a = new Many(new Character('a'));
            IMatch actual = a.Match("bc");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_IPattern_Char_a_And_String_bc_Should_Return_String_bc()
        {
            var a = new Many(new Character('a'));
            IMatch actual = a.Match("bc");
            Assert.Equal("bc", actual.RemainingText());
        }

        [Fact]
        public void For_IPattern_Char_a_And_String_EmptyString_Should_Return_True()
        {
            var a = new Many(new Character('a'));
            IMatch actual = a.Match(string.Empty);
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_IPattern_Char_a_And_String_EmptyString_Should_Return_String_EmptyString()
        {
            var a = new Many(new Character('a'));
            IMatch actual = a.Match(string.Empty);
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_IPattern_Range_0_9_And_String_12345ab123_Should_Return_True()
        {
            var digits = new Many(new Range('0', '9'));
            IMatch actual = digits.Match("12345ab123");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_IPattern_Range_0_9_And_String_12345ab123_Should_Return_ab123()
        {
            var digits = new Many(new Range('0', '9'));
            IMatch actual = digits.Match("12345ab123");
            Assert.Equal("ab123", actual.RemainingText());
        }

        [Fact]
        public void For_IPattern_Range_0_9_And_String_ab_Should_Return_True()
        {
            var digits = new Many(new Range('0', '9'));
            IMatch actual = digits.Match("ab");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_IPattern_Range_0_9_And_String_ab_Should_Return_ab()
        {
            var digits = new Many(new Range('0', '9'));
            IMatch actual = digits.Match("ab");
            Assert.Equal("ab", actual.RemainingText());
        }
    }
}
