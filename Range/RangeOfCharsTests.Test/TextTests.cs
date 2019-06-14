﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class TextTests
    {
        [Fact]
        public void For_Constructor_True_And_Text_True_Should_Return_True()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match("true");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Constructor_True_And_Text_True_Should_Return_Empty_String()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match("true");
            Assert.Equal("", actual.RemainingText());
        }

        [Fact]
        public void For_Constructor_True_And_Text_Truex_Should_Return_True()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match("truex");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Constructor_True_And_Text_Truex_Should_Return_x()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match("truex");
            Assert.Equal("x", actual.RemainingText());
        }

        [Fact]
        public void For_Constructor_True_And_Text_False_Should_Return_False()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match("false");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Constructor_True_And_Text_False_Should_Return_Text_false()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match("false");
            Assert.Equal("false", actual.RemainingText());
        }

        [Fact]
        public void For_Constructor_True_And_Text_Empty_String_Should_Return_False()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match("");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Constructor_True_And_Text_Empty_String_Should_Return_Empty_String()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match(string.Empty);
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Constructor_True_And_Text_Null_Should_Return_False()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match(null);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Constructor_True_And_Text_NUll_Should_Return_null()
        {
            var isTrue = new Text("true");
            IMatch actual = isTrue.Match(null);
            Assert.Equal(null, actual.RemainingText());
        }
    }
}
