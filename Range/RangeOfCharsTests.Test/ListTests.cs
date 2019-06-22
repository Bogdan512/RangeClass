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
    }
}
