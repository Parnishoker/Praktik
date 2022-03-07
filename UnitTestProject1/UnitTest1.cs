using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mylib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreate()
        {
            AptekaTest test = new AptekaTest();

            string actual = test.Create("Amirka", "q", "User");

            string expected = "Amirka";

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void ReadInformationTest()

        {

            AptekaTest test = new AptekaTest();

            string actual = test.ReadInformation("1");

            string expected = "1";

            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void RemoveUserTest()

        {

            AptekaTest test = new AptekaTest();

            string actual = test.RemoveUser("Amirka");

            string expected = "Amirka";

            Assert.AreEqual(actual, expected);

        }
    }
}
