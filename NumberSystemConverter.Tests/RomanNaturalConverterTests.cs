using System;
using Xunit;

namespace NumberSystemConverter.Tests
{
    public class RomanNaturalConverterTests
    {
        private RomanNumeralConverter converter;

        public RomanNaturalConverterTests()
        {
            converter = new RomanNumeralConverter();
        }

        [Fact]
        public void Number_Greater_Than_ThreeThousand_Throws_IndexOutOfRangeException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => converter.ConvertRomanNumeral(3001));
        }

        [Fact]
        public void Number_Less_Than_One_Throws_IndexOutOfRangeException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => converter.ConvertRomanNumeral(-1));
        }

        [Fact]
        public void Number_Zero_Throws_IndexOutOfRangeException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => converter.ConvertRomanNumeral(0));
        }
    }
}
