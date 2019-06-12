using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class AnyTests
    {
        [Fact]
        public void For_String_ea_Should_Return_True()
        {
            var e = new Any("eE");
            IMatch actual = e.Match("ea");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_String_ea_Should_Return_a()
        {
            var e = new Any("eE");
            IMatch actual = e.Match("ea");
            Assert.Equal("a", actual.RemainingText());
        }

        [Fact]
        public void For_String_Ea_Should_Return_True()
        {
            var e = new Any("eE");
            IMatch actual = e.Match("Ea");
            Assert.True(actual.Succes());
        }
    }
}
