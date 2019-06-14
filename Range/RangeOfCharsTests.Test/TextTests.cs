using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class TextTests
    {
        [Fact]
        public void For_Constructor_True_And_Text_True_Should_Return_True()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match("true");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Constructor_True_And_Text_True_Should_Return_Empty_String()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match("true");
            Assert.Equal("", actual.RemainingText());
        }
    }
}
