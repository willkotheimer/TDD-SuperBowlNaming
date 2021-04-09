using System;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    public class TranslateNumberToRomanNumerals
    {
        //this method is a test
        [Fact]
        //must be public, and return void, and take no parameters
        public void when_the_numer_1_is_passed_I_should_be_returned()
        {
            //Arrange
            var numberToConvert = 1;
            var translator = new RomanNumeralTranslator();
            //Act
            var result = translator.NumberToNumeral(numberToConvert);
            //Assert
            Assert.Equal("I", result);
        }

        [Fact]
        public void when_the_number_5_is_passed_V_should_be_returned()
        {
            var numberToConvert = 5;
            var translator = new RomanNumeralTranslator();
            var result = translator.NumberToNumeral(numberToConvert);
            Assert.Equal("V", result);
        }

        [Fact]
        public void when_the_number_9_is_passed_IX_should_be_returned()
        {
            var numberToConvert = 9;
            var translator = new RomanNumeralTranslator();
            var result = translator.NumberToNumeral(numberToConvert);
            Assert.Equal("IX", result);
        }

    }
}
