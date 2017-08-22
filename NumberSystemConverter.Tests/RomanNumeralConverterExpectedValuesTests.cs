using Xunit;

namespace NumberSystemConverter.Tests
{
    public class RomanNumeralConverterExpectedValuesTests
    {
        private RomanNumeralConverter converter;

        public RomanNumeralConverterExpectedValuesTests()
        {
            converter = new RomanNumeralConverter();
        }

        [Fact]
        public void Number_Equal_1_Expected_Result_I()
        {
            var result = converter.ConvertRomanNumeral(1);
            Assert.Equal(result, "I");
        }

        [Fact]
        public void Number_Equal_3000_Expected_Result_MMM()
        {
            var result = converter.ConvertRomanNumeral(3000);
            Assert.Equal(result, "MMM");
        }

        [Fact]
        public void Number_Equal_55_Expected_Result_LV()
        {
            var result = converter.ConvertRomanNumeral(55);
            Assert.Equal(result, "LV");
        }

        [Fact]
        public void Number_Equal_100_Expected_Result_C()
        {
            var result = converter.ConvertRomanNumeral(100);
            Assert.Equal(result, "C");
        }

        [Fact]
        public void Number_Equal_500_Expected_Result_D()
        {
            var result = converter.ConvertRomanNumeral(500);
            Assert.Equal(result, "D");
        }

        [Fact]
        public void Number_Equal_599_Expected_Result_DLXXXXVIIII()
        {
            var result = converter.ConvertRomanNumeral(599);
            Assert.Equal(result, "DLXXXXVIIII");
        }

        [Fact]
        public void Number_Equal_2013_Expected_Result_MMXIII()
        {
            var result = converter.ConvertRomanNumeral(2013);
            Assert.Equal(result, "MMXIII");
        }
    }
}
