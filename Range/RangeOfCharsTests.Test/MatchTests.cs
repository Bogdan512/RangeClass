using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class MatchTests
    {
        [Fact]
        public void Succes_Should_Return_True()
        {
            Match match = new Match(true, "abc");
            bool actual = match.Succes();
            Assert.True(actual);
        }

        [Fact]
        public void Succes_Should_Return_False()
        {
            Match match = new Match(false, "abc");
            bool actual = match.Succes();
            Assert.False(actual);
        }

        [Fact]
        public void Succes_Should_Return_RemainingText_abc()
        {
            Match match = new Match(false, "abc");
            string actual = match.RemainingText();
            Assert.Equal("abc", actual);
        }
    }
}
