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

        //[Fact]
        //public void For_gABC_Should_Return_False()
        //{
        //    var character = new Character('a');
        //    string text = "gbcg";
        //    bool actual = character.Match(text);
        //    Assert.False(actual);
        //}

        //[Fact]
        //public void For_1ABC_Should_Return_False()
        //{
        //    var character = new Character('a');
        //    string text = "1abc";
        //    bool actual = character.Match(text);
        //    Assert.False(actual);
        //}

        //[Fact]
        //public void For_Null_String_Should_Return_False()
        //{
        //    var character = new Character('a');
        //    string text = "";
        //    bool actual = character.Match(text);
        //    Assert.False(actual);
        //}

        //[Fact]
        //public void For_Empty_Should_Return_False()
        //{
        //    var character = new Character('f');
        //    string text = " ";
        //    bool actual = character.Match(text);
        //    Assert.False(actual);
        //}

        //[Fact]
        //public void For_A_Space_In_String_Should_Return_False()
        //{
        //    var character = new Character('a');
        //    string text = " abc ";
        //    bool actual = character.Match(text);
        //    Assert.False(actual);
        //}
    }
}
