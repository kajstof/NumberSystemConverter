using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSystemConverter
{
    public class RomanNumeralConverter
    {
        #region Supporting Types

        /// <summary>
        /// Roman Numerals
        /// </summary>
        /// <remarks>
        /// There are seven symbols that can be used to write any roman numeral
        /// </remarks>
        enum RomanNumeralsType
        {
            M = 1000,
            D = 500,
            C = 100,
            L = 50,
            X = 10,
            V = 5,
            I = 1
        }

        internal class RomanNumeralPair
        {
            public int NumericValue { get; set; }
            public string RomanNumeralRepresentation { get; set; }
        }

        #endregion

        private readonly List<RomanNumeralPair> romanNumeralList;

        public RomanNumeralConverter()
        {
            romanNumeralList = new List<RomanNumeralPair>()
            {
                new RomanNumeralPair() { NumericValue = Convert.ToInt32(RomanNumeralsType.M), RomanNumeralRepresentation = RomanNumeralsType.M.ToString() },
                new RomanNumeralPair() { NumericValue = Convert.ToInt32(RomanNumeralsType.D), RomanNumeralRepresentation = RomanNumeralsType.D.ToString() },
                new RomanNumeralPair() { NumericValue = Convert.ToInt32(RomanNumeralsType.C), RomanNumeralRepresentation = RomanNumeralsType.C.ToString() },
                new RomanNumeralPair() { NumericValue = Convert.ToInt32(RomanNumeralsType.L), RomanNumeralRepresentation = RomanNumeralsType.L.ToString() },
                new RomanNumeralPair() { NumericValue = Convert.ToInt32(RomanNumeralsType.X), RomanNumeralRepresentation = RomanNumeralsType.X.ToString() },
                new RomanNumeralPair() { NumericValue = Convert.ToInt32(RomanNumeralsType.V), RomanNumeralRepresentation = RomanNumeralsType.V.ToString() },
                new RomanNumeralPair() { NumericValue = Convert.ToInt32(RomanNumeralsType.I), RomanNumeralRepresentation = RomanNumeralsType.I.ToString() }
            };
        }

        public string ConvertRomanNumeral(int number)
        {
            if (number < 1 || number > 3000)
            {
                throw new IndexOutOfRangeException("The number supplied is out of the expected range (1 - 3000).");
            }

            StringBuilder sb = new StringBuilder();
            // iterate through the list, starting with the highest value
            foreach (var currentPair in romanNumeralList)
            {
                while (number >= currentPair.NumericValue)
                {
                    // ... number is greater than or equal to the current value so store the roman numeral and decrement it's value
                    sb.Append(currentPair.RomanNumeralRepresentation);
                    number -= currentPair.NumericValue;
                }
            }

            return sb.ToString();
        }
    }
}