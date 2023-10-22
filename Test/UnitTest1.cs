using ValidateHexcode;

namespace Test
{
    public class Tests
    {
        /*
         * A hex code must begin with a pound key # and is exactly 6 characters in length. 
         * Each character must be a digit from 0-9 or an alphabetic character from A-F. 
         * All alphabetic characters may be uppercase or lowercase.
         * 
         *  - https://edabit.com/challenge/8tyXtHqAT3LAuHMqu
         */

        [Test]
        [TestCase("#CD5C5C", true)]
        [TestCase("#EAECEE", true)]
        [TestCase("#eaecee", true)]
        [TestCase("#", false)] // To short
        [TestCase("#CD5C58C", false)] // Length exceeds 6
        [TestCase("#CD5C5Z", false)] // Not all alphabetic characters in A-F
        [TestCase("#CD5C&C", false)] // Contains unacceptable character
        [TestCase("CD5C5C", false)] // Missing #

        public void Test1(string hexcode, bool expected)
        {
            Assert.That(ValidateHexcode.Program.IsValidHexCode(hexcode) , Is.EqualTo(expected));
        }
    }
}