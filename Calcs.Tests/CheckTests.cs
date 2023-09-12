using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Check.Tests
{
    [TestClass]
    public class CheckTests
    { 
        Check _check = new Check(); 
        [TestMethod]
        public void Checking_NoMatchingCriteria_Returns0()
        {
            // Arrange
            string password = "Password!@123ridrirgtkc";
            int expected = 8;
            // Act
            int actual = _check.Checking(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Checking_ContainsDigits_Returns1()
        {
            // Arrange
            
            string password = "62";
            int expected = 1;
            // Act
            int actual = _check.Checking(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Checking_ContainsLowercaseLetters_Returns2()
        {
            // Arrange
            
            string password = "pass12";
            int expected = 2;
            // Act
            int actual = _check.Checking(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Checking_ContainsUppercaseLetters_Returns3()
        {
            // Arrange
            string password = "paSwor1";
            int expected = 3;
            // Act
            int actual = _check.Checking(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Checking_ContainsSpecialCharacters_Returns4()
        {
            // Arrange
            string password = "pas3123!";
            int expected = 4;
            // Act
            int actual = _check.Checking(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Checking_LengthGreaterThan7_Returns5()
        {
            // Arrange
            string password = "";
            int expected = 5;
            // Act
            int actual = _check.Checking(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}