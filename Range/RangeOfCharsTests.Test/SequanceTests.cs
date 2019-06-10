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

        [Fact]
        public void For_def_For_a_b_Should_Return_False()
        {
            var ab = new Sequance(
                new Character('a'),
                new Character('b')
            );

            IMatch actual = ab.Match("def");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_String_def_For_a_b_Should_Return_def_When_False()
        {
            var ab = new Sequance(
                new Character('a'),
                new Character('b')
            );

            IMatch actual = ab.Match("def");
            Assert.Equal("def",actual.RemainingText());
        }

        [Fact]
        public void For_Empty_String_Should_Return_False()
        {
            var ab = new Sequance(
                new Character('a'),
                new Character('b')
            );

            IMatch actual = ab.Match("");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Empty_String_Should_Return_Empty_String()
        {
            var ab = new Sequance(
                new Character('a'),
                new Character('b')
            );

            IMatch actual = ab.Match("");
            Assert.Equal("", actual.RemainingText());
        }

        [Fact]
        public void For_Null_Should_Return_false()
        {
            var ab = new Sequance(
                new Character('a'),
                new Character('b')
            );

            IMatch actual = ab.Match(null);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Null_Should_Return_Null()
        {
            var ab = new Sequance(
                new Character('a'),
                new Character('b')
            );

            IMatch actual = ab.Match(null);
            Assert.Null(actual.RemainingText());
        }

        [Fact]
        public void For_u1234_Should_Return_Empty_String()
        {
            var hex = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex));

            IMatch actual = hexSeq.Match("u1234");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_uabcdef_Should_Return_ef()
        {
            var hex = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex));

            IMatch actual = hexSeq.Match("uabcdef");
            Assert.Equal("ef", actual.RemainingText());
        }

        [Fact]
        public void For_uabcdef_Should_Return_true()
        {
            var hex = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex));

            IMatch actual = hexSeq.Match("uabcdef");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_uB005_ab_Should_Return_true()
        {
            var hex = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex));

            IMatch actual = hexSeq.Match("uB005 ab");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_uB005_ab_Should_Return__ab()
        {
            var hex = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex));

            IMatch actual = hexSeq.Match("uB005 ab");
            Assert.Equal(" ab", actual.RemainingText());
        }

        [Fact]
        public void For_abc_Should_Return_false()
        {
            var hex = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex));

            IMatch actual = hexSeq.Match("abc");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_abc_Should_Return_abc()
        {
            var hex = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex));

            IMatch actual = hexSeq.Match("abc");
            Assert.Equal("abc", actual.RemainingText());
        }

        [Fact]
        public void For_Null_Hex_Should_Return_Null()
        {
            var hex = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex));

            IMatch actual = hexSeq.Match(null);
            Assert.Null(actual.RemainingText());
        }
    }
}
