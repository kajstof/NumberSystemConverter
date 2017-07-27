using System;
using System.Linq;
using Xunit;

namespace NumberSystemConverter.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Number_Greater_Than_ThreeThousand_Throws_IndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            Assert.Throws<IndexOutOfRangeException>(() => converter.ConvertRomanNumeral(3001));
        }

        [Fact]
        public void Number_Less_Than_One_Throws_IndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(-1);
        }
    }
}
