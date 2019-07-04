using System;
using Xunit;

namespace RangeOfChars.Test
{
    public class NumberTests
    {
        [Fact]
        public void For_201_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("201");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_201_It_Should_Return_EmptyString()
        {
            var number = new Number();
            IMatch actual = number.Match("201");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_0201_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("0201");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_0201_It_Should_Return_201()
        {
            var number = new Number();
            IMatch actual = number.Match("0201");
            Assert.Equal("201", actual.RemainingText());
        }

        [Fact]
        public void For_Minus201_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("-201");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Minus201_It_Should_Return_EmptyStirng()
        {
            var number = new Number();
            IMatch actual = number.Match("-201");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_0002_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("0002");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_02_It_Should_Return_2()
        {
            var number = new Number();
            IMatch actual = number.Match("02");
            Assert.Equal("2", actual.RemainingText());
        }

        [Fact]
        public void For_20708_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("20708");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_20700_It_Should_Return_EmptyString()
        {
            var number = new Number();
            IMatch actual = number.Match("20700");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_0Punct708_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("0.708");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_0Punct708_It_Should_Return_EmptyString()
        {
            var number = new Number();
            IMatch actual = number.Match("0.708");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_0Punct70Punct8_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("0.70.8");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_0Punct70Punct8_It_Should_Return_Punct8()
        {
            var number = new Number();
            IMatch actual = number.Match("0.70.8");
            Assert.Equal(".8", actual.RemainingText());
        }

        [Fact]
        public void For_2Punct7_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("2.7");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_2Punct7_It_Should_Return_EmptyString()
        {
            var number = new Number();
            IMatch actual = number.Match("2.7");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_2Punct75Punct43_It_Should_Return_True()
        {
            var number = new Number();
            IMatch actual = number.Match("2.75.43");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_2Punct75Punct43_It_Should_Return_Punct43()
        {
            var number = new Number();
            IMatch actual = number.Match("2.75.43");
            Assert.Equal(".43", actual.RemainingText());
        }
    }
}
