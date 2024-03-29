﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RangeOfChars.Test
{
    public class StringTests
    {
        [Fact]
        public void For_text_It_Should_Return_true()
        {
            var text = new String();
            IMatch actual = text.Match("\"text\"");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_text_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"text\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_124_It_Should_Return_true()
        {
            var text = new String();
            IMatch actual = text.Match("\"124\"");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_124_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"124\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_124Text_It_Should_Return_true()
        {
            var text = new String();
            IMatch actual = text.Match("\"124Text\"");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_124Text_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"124Text\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_124SolidusText_It_Should_Return_true()
        {
            var text = new String();
            IMatch actual = text.Match("\"12 4Text\"");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_124SolidusText_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"12 4Text\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_12_Space_4SText_Solidus_Hex_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"12 4Text\\u0023\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_12_Space_4SText_Solidus_Hex_It_Should_Return_True()
        {
            var text = new String();
            IMatch actual = text.Match("\"12 4Text\u0023\"");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_124SolidusText56_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"12 4Text56\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_u002_It_Should_Return_True()
        {
            var text = new String();
            IMatch actual = text.Match("\"\u002f\"");
            Assert.True(actual.Succes());
        }

        [Fact]
        public void For_u002_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"\u002f\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_SolidusNewLine_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"\\/\\n\\r\\t\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }

        [Fact]
        public void For_abcNewLinedef_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"abc\\ndef\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }



        [Fact]
        public void For_aReverseSolidu1xbc_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"a\\u1xbc\"");
            Assert.Equal("\"a\\u1xbc\"", actual.RemainingText());
        }

        [Fact]
        public void For_quotationmark_It_Should_Return_EmptyString()
        {
            var text = new String();
            IMatch actual = text.Match("\"\\\"\"");
            Assert.Equal(string.Empty, actual.RemainingText());
        }
    }
}
