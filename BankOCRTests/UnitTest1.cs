using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BankOCR;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankOCRTests
{
    [TestClass]
    public class UnitTest1
    {

        private const string One = "   " + "\r\n" +
                                   "  |" + "\r\n" +
                                   "  |" + "\r\n" +
                                   "   " + "\r\n";

        private const string Two = " _ " + "\r\n" +
                                   " _|" + "\r\n" +
                                   "|_ " + "\r\n" +
                                   "   " + "\r\n";

        private const string Three = " _ " + "\r\n" +
                                     " _|" + "\r\n" +
                                     " _|" + "\r\n" +
                                     "   " + "\r\n";

        private const string Four = "   " + "\r\n" +
                                    "|_|" + "\r\n" +
                                    "  |" + "\r\n" +
                                    "   " + "\r\n";

        private const string Five = " _ " + "\r\n" +
                                    "|_ " + "\r\n" +
                                    " _|" + "\r\n" +
                                    "   " + "\r\n";

        private const string Six = " _ " + "\r\n" +
                                   "|_ " + "\r\n" +
                                   "|_|" + "\r\n" +
                                   "   " + "\r\n";

        private const string Seven = " _ " + "\r\n" +
                                     "  |" + "\r\n" +
                                     "  |" + "\r\n" +
                                     "   " + "\r\n";

        private const string Eight = " _ " + "\r\n" +
                                     "|_|" + "\r\n" +
                                     "|_|" + "\r\n" +
                                     "   " + "\r\n";

        private const string Nine = " _ " + "\r\n" +
                                    "|_|" + "\r\n" +
                                    " _|" + "\r\n" +
                                    "   " + "\r\n";

        private const string Zero = " _ " + "\r\n" +
                                    "| |" + "\r\n" +
                                    "|_|" + "\r\n" +
                                    "   " + "\r\n";
        
        private string MultipleDigitNumber(params string[] digits)
        {
            var newNumber = new StringBuilder();
            for (var i = 0; i <= 3; i++)
            {                
                foreach (var digit in digits)
                {
                    var lines = digit.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    newNumber.Append(lines[i]);
                }
                newNumber.Append("\r\n");
            }
            return newNumber.ToString();

        }

        [TestMethod]
        public void ParsingOne()
        {
            Assert.AreEqual(1, Program.ParseDigit(One));
        }


        [TestMethod]
        public void ParsingFour()
        {

            Assert.AreEqual(4, Program.ParseDigit(Four));
        }

        [TestMethod]
        public void ParsingSeven()
        {


            Assert.AreEqual(7, Program.ParseDigit(Seven));
        }

        [TestMethod]
        public void ParsingThree()
        {

            Assert.AreEqual(3, Program.ParseDigit(Three));
        }

        [TestMethod]
        public void ParsingTwo()
        {

            Assert.AreEqual(2, Program.ParseDigit(Two));
        }

        [TestMethod]
        public void ParsingFive()
        {

            Assert.AreEqual(5, Program.ParseDigit(Five));
        }

        [TestMethod]
        public void ParsingEight()
        {

            Assert.AreEqual(8, Program.ParseDigit(Eight));
        }

        [TestMethod]
        public void ParsingNine()
        {

            Assert.AreEqual(9, Program.ParseDigit(Nine));
        }

        [TestMethod]
        public void ParsingZero()
        {

            Assert.AreEqual(0, Program.ParseDigit(Zero));
        }

        [TestMethod]
        public void ParsingSix()
        {

            Assert.AreEqual(6, Program.ParseDigit(Six));
        }

        [TestMethod]
        public void ParsingTen()
        {
            Assert.AreEqual(10, MultipleDigitNumber(One, Zero));
        }

        [TestMethod]
        public void BuildTen()
        {
            var ten = "    _ " + "\r\n" +
                      "  || |" + "\r\n" +
                      "  ||_|" + "\r\n" +
                      "      " + "\r\n";

            Assert.AreEqual(ten, MultipleDigitNumber(One, Zero));
        }
    }
}
