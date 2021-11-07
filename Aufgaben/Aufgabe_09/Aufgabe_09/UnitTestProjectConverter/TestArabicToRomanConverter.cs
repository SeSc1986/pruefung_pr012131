using System;

using Aufgabe_09;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aufgabe_09
{
    [TestClass]
    public class TestArabicToRomanConverter
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string input = "123";
            ArabicToRomanConverter atrc = new ArabicToRomanConverter(input);
            string expectedOutput = "CXXIII";
            string expectedconversionMessage = ArabicToRomanConverter.CONVERSION_SUCCES;

            // Act
            string output = atrc.ConversionResult();
            string conversionMessage = atrc.ConversionMessage();

            // Assert
            Assert.AreEqual(expectedOutput, output);
            Assert.AreEqual(expectedconversionMessage, conversionMessage);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string input = "AbS";
            ArabicToRomanConverter atrc = new ArabicToRomanConverter(input);
            string expectedOutput = "NaI";
            string expectedconversionMessage = ArabicToRomanConverter.CONVERSION_FAILED_NaI;

            // Act
            string output = atrc.ConversionResult();
            string conversionMessage = atrc.ConversionMessage();

            // Assert
            Assert.AreEqual(expectedOutput, output);
            Assert.AreEqual(expectedconversionMessage, conversionMessage);
        }

    }
}
