using System;
using Xunit;

namespace RangeOfChars.Test
{
    public class NumberTests
    {
        [Fact]
        public void For_2_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("2");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_278_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("278");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_0002_It_Should_Return_False()
        {
            var number = new Number();
            IMatch actual = number.Match("0002");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_02_It_Should_Return_02()
        {
            var number = new Number();
            IMatch actual = number.Match("02");
            Assert.Equal("02", actual.RemainingText());
        }

        [Fact]
        public void For_20708_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("20708");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_20708_It_Should_Return_EmptyString()
        {
            var number = new Number();
            IMatch actual = number.Match("207");
            Assert.Equal(string.Empty, actual.RemainingText());
        }
    }
}
