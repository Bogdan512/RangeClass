using System;
using Xunit;

namespace RangeOfChars.Test
{
    public class NumberTests
    {
        [Fact]
        public void For_20Coma2ComaComa521_It_Should_Return_False()
        {
            var number = new Number();
            IMatch actual = number.Match("20.2..521");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_20Coma2ComaComa521_It_Should_Return_20Coma2ComaComa521()
        {
            var number = new Number();
            IMatch actual = number.Match("20.2..521");
            Assert.Equal("20.2..521", actual.RemainingText());
        }

        //[Fact]
        //public void For_0002_It_Should_Return_False()
        //{
        //    var number = new Number();
        //    IMatch actual = number.Match("0002");
        //    Assert.False(actual.Succes());
        //}

        //[Fact]
        //public void For_02_It_Should_Return_02()
        //{
        //    var number = new Number();
        //    IMatch actual = number.Match("02");
        //    Assert.Equal("02", actual.RemainingText());
        //}

        //[Fact]
        //public void For_20708_It_Should_Return_True()
        //{
        //    var number = new Number();
        //    IMatch actual = number.Match("20708");
        //    Assert.True(actual.Succes());
        //}

        //[Fact]
        //public void For_20700_It_Should_Return_EmptyString()
        //{
        //    var number = new Number();
        //    IMatch actual = number.Match("20700");
        //    Assert.Equal(string.Empty, actual.RemainingText());
        //}

        //[Fact]
        //public void For_Minus207_It_Should_Return_True()
        //{
        //    var number = new Number();
        //    IMatch actual = number.Match("-207");
        //    Assert.True(actual.Succes());
        //}

        //[Fact]
        //public void For_Minus207_It_Should_Return_EmptyString()
        //{
        //    var number = new Number();
        //    IMatch actual = number.Match("-207");
        //    Assert.Equal(string.Empty, actual.RemainingText());
        //}

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
