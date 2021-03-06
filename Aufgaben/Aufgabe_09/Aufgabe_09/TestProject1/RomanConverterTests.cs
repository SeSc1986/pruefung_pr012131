using Aufgabe_09;
using RomanNumerals;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
    public class RomanConverterTests
    {
        [Fact]
        public void TestAllValidArabicInput()
        {
            RomanConverter rc = new RomanConverter();

            for (int i = 1; i < 4000; i++)
            {
                string expectedOutput = i.ToRomanNumerals();
                string output = rc.ConvertIntToRoman(i);

                output.Should().Be(expectedOutput);
            }
        }

        [Theory]
        [InlineData("XXXX")]
        [InlineData("IC")]
        public void TestInvalidInput(string input)
        {
            // Arrange
            RomanConverter rc = new RomanConverter();

            // Act
            int output = rc.ConvertRomanToInt(input);

            // Assert
            output.Should().Be(-1);
        }


        [Fact]
        public void TestAllValidRomanInput()
        {
            RomanConverter rc = new RomanConverter();

            for (int i = 1; i < 4000; i++)
            {
                int expectedOutput = i;
                int output = rc.ConvertRomanToInt(i.ToRomanNumerals());

                output.Should().Be(expectedOutput);
            }
        }


        [Theory]
        [InlineData("MCMXCVII", 1997)]
        [InlineData("MMIX", 2009)]
        [InlineData("CDXIV", 414)]
        public void TestSamples(string roman, int arabic)
        {
            // Arrange
            RomanConverter rc = new RomanConverter();

            // Act
            int arabicOutput = rc.ConvertRomanToInt(roman);
            string romanOutput = rc.ConvertIntToRoman(arabic);

            // Assert
            arabicOutput.Should().Be(arabic);
            romanOutput.Should().Be(roman);
        }
    }
}
