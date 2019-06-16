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
    }
}
