using System;
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

        [Fact]
        public void For_Constructor_False_And_Text_False_Should_Return_True()
        {
            var isFalse = new Text("false");
            IMatch actual = isFalse.Match("false");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Constructor_False_And_Text_False_Should_Return_Text_Emprty_String()
        {
            var isFalse = new Text("false");
            IMatch actual = isFalse.Match("false");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Constructor_False_And_Text_Falsex_Should_Return_True()
        {
            var isFalse = new Text("false");
            IMatch actual = isFalse.Match("falsex");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Constructor_False_And_Text_Falsex_Should_Return_Text_x()
        {
            var isFalse = new Text("false");
            IMatch actual = isFalse.Match("falsex");
            Assert.Equal("x", actual.RemainingText());
        }

        [Fact]
        public void For_Constructor_False_And_Text_True_Should_Return_False()
        {
            var isFalse = new Text("false");
            IMatch actual = isFalse.Match("true");
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Constructor_False_And_Text_True_Should_Return_Text_true()
        {
            var isFalse = new Text("false");
            IMatch actual = isFalse.Match("true");
            Assert.Equal("true", actual.RemainingText());
        }

        [Fact]
        public void For_Constructor_False_And_Text_Empty_String_Should_Return_False()
        {
            var isFalse = new Text("false");
            IMatch actual = isFalse.Match(string.Empty);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Constructor_False_And_Text_Empty_String_Should_Return_Empty_String()
        {
            var isFalse = new Text("false");
            IMatch actual = isFalse.Match(string.Empty);
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Constructor_False_And_Text_Null_Should_Return_False()
        {
            var isFalse = new Text("false");
            IMatch actual = isFalse.Match(null);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Constructor_False_And_Text_Null_Should_Return_Null()
        {
            var isFalse = new Text("false");
            IMatch actual = isFalse.Match(null);
            Assert.Null(actual.RemainingText());
        }

        [Fact]
        public void For_Constructor_Empty_String_And_Text_True_Should_Return_True()
        {
            var isFalse = new Text(string.Empty);
            IMatch actual = isFalse.Match("true");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_Constructor_Empty_String_And_Text_True_Should_Return_Text_True()
        {
            var isFalse = new Text(string.Empty);
            IMatch actual = isFalse.Match("true");
            Assert.Equal("true", actual.RemainingText());
        }

        [Fact]
        public void For_Constructor_Empty_String_And_Text_Null_Should_Return_False()
        {
            var isFalse = new Text(string.Empty);
            IMatch actual = isFalse.Match(null);
            Assert.False(actual.Succes());
        }

        [Fact]
        public void For_Constructor_Empty_String_And_Text_Null_Should_Return_null()
        {
            var isFalse = new Text(string.Empty);
            IMatch actual = isFalse.Match(null);
            Assert.Null(actual.RemainingText());
        }
    }
}
