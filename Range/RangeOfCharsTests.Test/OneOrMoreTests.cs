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

        [Fact]
        public void Should_Consume_More_Characters_From_String()
        {
            var a = new OneOrMore(new Character('a'));
            IMatch actual = a.Match("aaabc");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void Should_Consume_More_Characters_From_String_With_RemainingTest_bc()
        {
            var a = new OneOrMore(new Character('a'));
            IMatch actual = a.Match("aaabc");
            Assert.Equal("bc", actual.RemainingText());
        }

        [Fact]
        public void Should_Return_False_When_No_Character_Is_Consumed()
        {
            var a = new OneOrMore(new Character('a'));
            IMatch actual = a.Match("bc");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void When_No_Character_Is_Consumed_Should_Return_Initial_Text()
        {
            var a = new OneOrMore(new Character('a'));
            IMatch actual = a.Match("bc");
            Assert.Equal("bc", actual.RemainingText());
        }

        [Fact]
        public void For_aabac_Should_Return_True()
        {
            var a = new OneOrMore(new Character('a'));
            IMatch actual = a.Match("aabac");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_aabac_Should_Return_bac()
        {
            var a = new OneOrMore(new Character('a'));
            IMatch actual = a.Match("aabac");
            Assert.Equal("bac", actual.RemainingText());
        }
    }
}
