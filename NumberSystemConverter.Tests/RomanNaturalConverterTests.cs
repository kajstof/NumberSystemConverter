using System;
using Xunit;

namespace NumberSystemConverter.Tests
{
    public class RomanNaturalConverterTests
    {
        private RomanNumeralConverter _converter;

        private void Execute()
        {
            _converter = new RomanNumeralConverter();
        }

        [Fact]
        public void Number_Greater_Than_ThreeThousand_Throws_IndexOutOfRangeException()
        {
            Execute();
            Assert.Throws<IndexOutOfRangeException>(() => _converter.ConvertRomanNumeral(3001));
        }

        [Fact]
        public void Number_Less_Than_One_Throws_IndexOutOfRangeException()
        {
            Execute();
            _converter.ConvertRomanNumeral(-1);
        }
    }
}
