﻿using System;
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
    }
}