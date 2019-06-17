using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class OneOrMoreTests
    {
        [Fact]
        public void Should_Consume_The_First_Character_From_String()
        {
            var a = new OneOrMore(new Character('a'));
            IMatch actual = a.Match("abc");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void Should_Consume_The_First_Character_From_String_With_RemainingTest_bc()
        {
            var a = new OneOrMore(new Character('a'));
            IMatch actual = a.Match("abc");
            Assert.Equal("bc", actual.RemainingText());
        }
    }
}
