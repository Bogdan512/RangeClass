using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class CharacterTests
    {
        [Fact]
        public void For_ABC_Should_Return_True()
        {
            var character = new Character('a');
            string text = "abc";
            IMatch actual = character.Match(text);
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_ABC_Should_Return_bc()
        {
            var character = new Character('a');
            string text = "abc";
            IMatch actual = character.Match(text);
            Assert.Equal("bc", actual.RemainingText());
        }

        [Fact]
        public void For_ABC_Should_Return_False()
        {
            var character = new Character('b');
            string text = "abc";
            IMatch actual = character.Match(text);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_ABC_Should_Return_abc()
        {
            var character = new Character('b');
            string text = "abc";
            IMatch actual = character.Match(text);
            Assert.Equal("abc", actual.RemainingText());
        }

        [Fact]
        public void For_Empty_String_Should_Return_False()
        {
            var character = new Character('f');
            string text = "";
            IMatch actual = character.Match(text);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Empty_String_Should_Return_Empty_String()
        {
            var character = new Character('f');
            string text = "";
            IMatch actual = character.Match(text);
            Assert.Equal("", actual.RemainingText());
        }

        [Fact]
        public void For_Null_Should_Return_False()
        {
            var character = new Character('f');
            string text = null;
            IMatch actual = character.Match(text);
            Assert.False(actual.Succes());
        }
    }
}
