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
                new Range('1', '9')
            );
            IMatch actual = digit.Match("024");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void Should_Return_The_Rest_Of_The_text_For_True_For_Digit_0()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );
            IMatch actual = digit.Match("024");
            Assert.Equal("24", actual.RemainingText());
        }

        [Fact]
        public void Should_Return_True_For_Range_1_To_9()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );
            IMatch actual = digit.Match("12");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void Should_Return_Remaining_Text_For_True_For_Range_1_To_9()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );
            IMatch actual = digit.Match("12");
            Assert.Equal("2",actual.RemainingText());
        }

        [Fact]
        public void Should_Return_True_For_A9_Hex()
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

            IMatch actual = hex.Match("A9");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void Should_Return_Rest_Of_Text_For_True_For_269_Hex()
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

            IMatch actual = hex.Match("269");
            Assert.Equal("69", actual.RemainingText());
        }

        [Fact]
        public void Should_Return_False_For_g8_Hex()
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

            IMatch actual = hex.Match("g8");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void Should_Return_RemainingText_For_False_For_g8_Hex()
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

            IMatch actual = hex.Match("g8");
            Assert.Equal("g8", actual.RemainingText());
        }

        [Fact]
        public void Should_Return_False_For_Empty_String_Hex()
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

            IMatch actual = hex.Match(string.Empty);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void Should_Return_Empty_String_For_False_For_Empty_String_Hex()
        {

            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));
            var hex = new Choice(
                digit,
                new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F')));

            IMatch actual = hex.Match(string.Empty);
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void Should_Return_False_For_Null_Hex()
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

            IMatch actual = hex.Match(null);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void Should_Return_Null_For_Null_Hex()
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

            IMatch actual = hex.Match(null);
            Assert.Null(actual.RemainingText());
        }

        [Fact]
        public void Should_Return_Empty_String_For_True_For_8_Hex()
        {

            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            var hex = new Choice(
                digit,
                new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F')));

            IMatch actual = hex.Match("8");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void Add_Method_Should_Return_Empty_String_For_True_For_8_Hex()
        {

            //var digit = new Choice(
            //    new Character('0'),
            //    new Range('1', '9'));

            var hex = new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F'));

            hex.Add(range);

            IMatch actual = hex.Match("8");
            Assert.Equal(string.Empty, actual.RemainingText());
        }
    }
}
