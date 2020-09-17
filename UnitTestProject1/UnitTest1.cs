using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AuthTest()
        {

            var page = new AuthoPage();


            Assert.IsTrue(page.Auth("test", "test"));
            Assert.IsFalse(page.Auth("Test", "test"));
            Assert.IsFalse(page.Auth("test", "Test"));
            Assert.IsFalse(page.Auth("test1", "test"));
            Assert.IsFalse(page.Auth("test", "test1"));
            Assert.IsFalse(page.Auth("", ""));
            Assert.IsFalse(page.Auth(" ", ""));
            Assert.IsFalse(page.Auth("", " "));
            Assert.IsFalse(page.Auth("^^", "&&"));
            Assert.IsFalse(page.Auth("^^", "^^"));
            Assert.IsFalse(page.Auth("4353490588278395829035", "231948789231784721982374"));
            


        }
    }
}
