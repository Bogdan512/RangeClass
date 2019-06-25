using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class StringTests
    {
        [Fact]
        public void For_text_Should_Return_True()
        {
            var str = new ValidateString();
            IMatch actual = str.Match("\"text\"");
            Assert.True(actual.Succes());
        }
    }
}
