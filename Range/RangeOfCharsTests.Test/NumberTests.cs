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
        public void For_0201_It_Should_Return_False()
        {
            var number = new Number();
            IMatch actual = number.Match("0201");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_0201_It_Should_Return_0201()
        {
            var number = new Number();
            IMatch actual = number.Match("0201");
            Assert.Equal("0201", actual.RemainingText());
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
        public void For_20700_It_Should_Return_EmptyString()
        {
            var number = new Number();
            IMatch actual = number.Match("20700");
            Assert.Equal(string.Empty, actual.RemainingText());
        }


        //[Fact]
        //public void For_2Coma7_It_Should_Return_True()
        //{
        //    var number = new Number();
        //    IMatch actual = number.Match("2.7");
        //    Assert.True(actual.Succes());
        //}

        //[Fact]
        //public void For_2354Coma7_It_Should_Return_EmptyString()
        //{
        //    var number = new Number();
        //    IMatch actual = number.Match("2354.7");
        //    Assert.Equal(string.Empty, actual.RemainingText());
        //}

        //[Fact]
        //public void For_2Coma75Coma43_It_Should_Return_False()
        //{
        //    var number = new Number();
        //    IMatch actual = number.Match("2.75.43");
        //    Assert.False(actual.Succes());
        //}
    }
}
