using System;
using Xunit;

namespace RangeOfChars.Test
{
    public class NumberTests
    {
        [Fact]
        public void For_2_It_Should_Return_True()
        {
            var number = new Number(new Range('0', '9'));
            IMatch actual = number.Match("2");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_278_It_Should_Return_True()
        {
            var number = new Number(new Range('0', '9'));
            IMatch actual = number.Match("278");
            Assert.True(actual.Succes());
        }
    }
}
