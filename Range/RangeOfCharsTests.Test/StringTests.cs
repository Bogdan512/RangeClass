using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class StringTests
    {
        [Fact]
        public void For_text_It_Should_Return_true()
        {
            var text = new String();
            IMatch actual = text.Match("\"text\"");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_text_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"text\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }
    }
}
