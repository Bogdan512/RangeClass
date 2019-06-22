using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class ListTests
    {
        [Fact]
        public void It_Should_Consume_A_Pattern_And_A_Character_Returning_True()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            IMatch actual = a.Match("1");
            Assert.True(actual.Succes());
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
    }
}
