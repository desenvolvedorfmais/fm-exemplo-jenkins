using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleBuildJenkins;

namespace SampleBuildJenkinsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }
    }
}
