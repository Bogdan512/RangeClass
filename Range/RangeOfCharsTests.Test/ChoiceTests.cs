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
            var digit = new Choice(
                new Character('0'),
                new Range('1','9')
            );
            bool actual = digit.Match("024");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_True_For_Range_1_To_9()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );
            bool actual = digit.Match("12");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_False_For_92()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('2', '9')
            );
            bool actual = digit.Match("92");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_False_For_a9()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('2', '9')
            );
            bool actual = digit.Match("a9");
            Assert.False(actual);
        }

        [Fact]
        public void Should_Return_False_For_Empty_String()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('2', '9')
            );
            bool actual = digit.Match("");
            Assert.False(actual);
        }

        [Fact]
        public void Should_Return_False_For_Null()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('2', '9')
            );
            bool actual = digit.Match(null);
            Assert.False(actual);
        }

        [Fact]
        public void Should_Return_True_For_012()
        {

            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );

            var hex = new Choice(
                digit,
                new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F')
                )
            );

            bool actual = hex.Match("012");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_True_For_12()
        {

            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );

            var hex = new Choice(
                digit,
                new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F')
                )
            );

            bool actual = hex.Match("12");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_True_For_92()
        {

            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );

            var hex = new Choice(
                digit,
                new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F')
                )
            );

            bool actual = hex.Match("92");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_True_For_a9()
        {

            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );

            var hex = new Choice(
                digit,
                new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F')
                )
            );

            bool actual = hex.Match("a9");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_True_For_f8()
        {

            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );

            var hex = new Choice(
                digit,
                new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F')
                )
            );

            bool actual = hex.Match("f8");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_True_For_A9()
        {

            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );

            var hex = new Choice(
                digit,
                new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F')
                )
            );

            bool actual = hex.Match("A9");
            Assert.True(actual);
        }

        [Fact]
        public void Should_Return_True_For_F8()
        {

            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );

            var hex = new Choice(
                digit,
                new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F')
                )
            );

            bool actual = hex.Match("F8");
            Assert.True(actual);
        }
    }
}
