using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class OptionalTests
    {
        [Fact]
        public void For_Character_a_and_String_abc_Should_Return_True()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match("abc");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Character_a_and_String_abc_Should_Return_bc()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match("abc");
            Assert.Equal("bc", actual.RemainingText());
        }

        [Fact]
        public void For_Character_a_and_String_aabc_Should_Return_True()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match("aabc");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Character_a_and_String_aabc_Should_Return_abc()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match("aabc");
            Assert.Equal("abc", actual.RemainingText());
        }

        [Fact]
        public void For_Character_a_and_String_bc_Should_Return_True()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match("bc");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Character_a_and_String_bc_Should_Return_bc()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match("bc");
            Assert.Equal("bc", actual.RemainingText());
        }

        [Fact]
        public void For_Character_a_and_String_EmptyString_Should_Return_True()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match(string.Empty);
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Character_a_and_String_EmptyString_Should_Return_EmptyString()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match(string.Empty);
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Character_a_and_String_null_Should_Return_True()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match(null);
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Character_a_and_String_null_Should_Return_null()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match(null);
            Assert.Equal(null, actual.RemainingText());
        }

        [Fact]
        public void For_Character_Minus_and_String_123_Should_Return_true()
        {
            var sign = new Optional(new Character('-'));
            IMatch actual = sign.Match("123");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Character_Minus_and_String_123_Should_Return_123()
        {
            var a = new Optional(new Character('a'));
            IMatch actual = a.Match("123");
            Assert.Equal("123", actual.RemainingText());
        }
    }
}
