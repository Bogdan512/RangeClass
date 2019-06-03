using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class ChoiceTests
    {
        [Fact]
        public void Should_Return_True_For_Digit_0()
        {
            var digit = new Choice
            (
                new Character('0'),
                new Range('1','9')
            );
            bool actual = digit.Match("024");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_True_For_Range_1_To_9()
        {
            var digit = new Choice
            (
                new Character('0'),
                new Range('1', '9')
            );
            bool actual = digit.Match("214");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_False_For_1024()
        {
            var digit = new Choice
            (
                new Character('0'),
                new Range('2', '9')
            );
            bool actual = digit.Match("1024");
            Assert.False(actual);
        }
    }
}
