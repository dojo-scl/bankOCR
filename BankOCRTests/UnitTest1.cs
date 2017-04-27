using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using BankOCR;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankOCRTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ParsingOne()
        {
            var one = "   " + "\r\n" +
                      "  |" + "\r\n" +
                      "  |" + "\r\n" +
                      "   " + "\r\n";

            Assert.AreEqual(1, Program.ParseNumber(one));
        }


        [TestMethod]
        public void ParsingFour()
        {
     
            var four ="   " + "\r\n" +
                      "|_|" + "\r\n" +
                      "  |" + "\r\n" +
                      "   " + "\r\n";

           Assert.AreEqual(4, Program.ParseNumber(four));
        }

        public void ParsingSeven()
        {

            var seven =" _ " + "\r\n" +
                       "  |" + "\r\n" +
                       "  |" + "\r\n" +
                       "   " + "\r\n";

            Assert.AreEqual(7, Program.ParseNumber(seven));
        }
    }
}
