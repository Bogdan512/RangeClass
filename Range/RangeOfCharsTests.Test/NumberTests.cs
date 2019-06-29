using System;
using Xunit;

namespace RangeOfChars
{
    public class NumberTests
    {
        [Fact]
        public void For_234_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("234");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_0234_It_Should_Return_False()
        {
            var number = new Number();
            IMatch actual = number.Match("0234");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_FullStop234_It_Should_Return_False()
        {
            var number = new Number();
            IMatch actual = number.Match(".234");
            Assert.False(actual.Succes());

        }

        [Fact]
        public void For_0FullStop234_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("0.234");
            Assert.True(actual.Succes());

        }
    }
}
