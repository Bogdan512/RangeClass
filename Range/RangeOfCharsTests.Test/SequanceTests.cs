using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class SequanceTests
    {
        [Fact]
        public void For_abcd_For_a_b_Should_Return_True()
        {
            var ab = new Sequance(
                new Character('a'),
                new Character('b')
            );

            IMatch actual = ab.Match("abcd");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_abcd_For_a_b_Should_Return_cd_For_True()
        {
            var ab = new Sequance(
                new Character('a'),
                new Character('b')
            );

            IMatch actual = ab.Match("abcd");
            Assert.Equal("cd",actual.RemainingText());
        }
    }
}
