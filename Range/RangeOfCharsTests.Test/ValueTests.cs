using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class ValueTests
    {
        [Fact]
        public void For_String_Text_Should_Return_EmptyString()
        {
            var value = new Value();
            IMatch actual = value.Match("\"String\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Number_24_Should_Return_EmptyString()
        {
            var value = new Value();
            IMatch actual = value.Match("24");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Text_truex_Should_Return_x()
        {
            var value = new Value();
            IMatch actual = value.Match("truex");
            Assert.Equal("x", actual.RemainingText());
        }

        [Fact]
        public void For_Text_falsex_Should_Return_x()
        {
            var value = new Value();
            IMatch actual = value.Match("falsex");
            Assert.Equal("x", actual.RemainingText());
        }

        [Fact]
        public void For_Text_nullx_Should_Return_x()
        {
            var value = new Value();
            IMatch actual = value.Match("nullx");
            Assert.Equal("x", actual.RemainingText());
        }

        [Fact]
        public void For_Empty_Brackets_Should_Return_EmptyString()
        {
            var value = new Value();
            IMatch actual = value.Match("[]");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Tab_Inside_Brackets_Should_Return_EmptyString()
        {
            var value = new Value();
            IMatch actual = value.Match("[\u0009\t]");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Element_true_Should_Return_EmptyString()
        {
            var value = new Value();
            IMatch actual = value.Match("true");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Elements_trueNumber_Should_Return_EmptyString()
        {
            var value = new Value();
            IMatch actual = value.Match("true,24.45e+5");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_Complete_Array_Should_Return_EmptyString()
        {
            var value = new Value();
            IMatch actual = value.Match("[true,24.45e+5]");
            Assert.Equal(string.Empty, actual.RemainingText());
        }
    }
}
