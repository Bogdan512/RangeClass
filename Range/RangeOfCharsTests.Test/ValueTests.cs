using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class ValueTests
    {
        [Fact]
        public void For_String_Text_Should_Return_EmptyString()
        {
            var value = new Value();
            IMatch actual = value.Match("\"String\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Number_24_Should_Return_EmptyString()
        {
            var value = new Value();
            IMatch actual = value.Match("24");
            Assert.Equal(string.Empty, actual.RemainingText());
        }
    }
}
