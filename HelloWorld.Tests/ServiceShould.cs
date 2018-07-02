
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{

    [TestClass]
    public class ServiceShould
    {

        [TestMethod]
        public void Return_Correct_Place()
        {
            var systemUnderTest = new Service();

            var actual = systemUnderTest.GetServiceString();

            Assert.AreEqual(actual, "World");
        }

    }
}
