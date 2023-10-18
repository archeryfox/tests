using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Stub.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void FindLogFile_FiletopDopOp_truereturns()
        {
            var mng = new FileManager();
            var actual = mng.FindLogFile("FiletopDopOp.txt");
            Assert.IsTrue(actual);
        }
    }
}