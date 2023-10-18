using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using Stringis;

namespace Strings.Tests
{
    [TestClass]
    public class StringsCheckTests
    {

        [TestMethod]
        public void ShortestWord_FindsShortestWordInString_ReturnsThe()
        {
            string input = "The quick brown foxy jumps over the lazy dog";
            string expectedOutput = "The";
            
        }
         
        [TestMethod]
        public void WordCount_NumberOfWordsInString_Returns9()
        {
            string input = "The quick brown fox jumps over the lazy dog";
            int expectedOutput = 9;
            StringsCheck strings = new StringsCheck();
            Assert.AreEqual(expectedOutput, strings.WordCount(input));
            Assert.IsTrue(strings.WordCount(input) > 0);
        }

        [TestMethod]
        public void CharacterCount_NumberOfCharactersInString_Returns43()
        {
            string input = "The quick brown fox jumps over the lazy dog";
            int expectedOutput = 43;
            StringsCheck strings = new StringsCheck();
            Assert.AreEqual(expectedOutput, strings.CharacterCount(input));
        }

        [TestMethod]
        public void NthCharacter_NthCharacterInString_Returnsb()
        {
            // Arrange
            string input = "The quick brown fox jumps over the lazy dog";
            char expectedOutput = 'b';
            int index = 10;
            StringsCheck strings = new StringsCheck();
            char actualOutput = strings.NthCharacter(input, index);
            Assert.AreEqual(expectedOutput, actualOutput);
            Assert.IsInstanceOfType(actualOutput, typeof(char));
        }

        [TestMethod]
        public void DigitCount_NumberOfDigitsInString_Returns10()
        {
            string input = "The quick brown fox jumps over the 1234567890";
            int expectedOutput = 10;
            StringsCheck strings = new StringsCheck();
            Assert.AreEqual(expectedOutput, strings.DigitCount(input));
            StringAssert.StartsWith(input, "T" );
        }

        [TestMethod]
        public void MaxConsecutiveDigits_MaximumNumberOfConsecutiveDigitsInString_Returns10()
        {
            string input = "The quick brown fox jumps over the 1234567890";
            int expectedOutput = 10;
            StringsCheck strings = new StringsCheck();
            Assert.AreEqual(expectedOutput, strings.MaxConsecutiveDigits(input));
            Assert.IsFalse(strings.MaxConsecutiveDigits("The quick brown fox jumps over the lazy dog") > 0);
        }

        [TestMethod]
        public void SubstringCount_NumberOfOccurrencesOfSubstringInString_Returns1()
        {
            string input = "ам амогус";
            int expectedOutput = 2;
            StringsCheck strings = new StringsCheck();
            StringAssert.Matches(input, new Regex("ам"));
            Assert.AreEqual(expectedOutput, strings.SubstringCount(input, "ам"));
        }

    }
}
