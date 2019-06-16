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
    }
}
