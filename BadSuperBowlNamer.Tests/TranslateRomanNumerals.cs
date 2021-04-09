﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    public class TranslateRomanNumerals
    {
        [Theory]
        [InlineData(1,"I")]
        [InlineData(2, "II")]
        [InlineData(14, "XIV")]
        [InlineData(49, "XLIX")]
        [InlineData(143, "CXLIII")]
        public void the_number_is_translated_correctly_to_roman_numerals(int numberToConvert, string expectedNumeral)
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            //Act
            var actualResult = translator.NumberToNumeral(numberToConvert);
            //Assert
            Assert.Equal(expectedNumeral, actualResult);
        }
    }
}
