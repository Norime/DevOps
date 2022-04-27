using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adelys;


namespace AdelysTests
{
    [TestClass]
    public class AdelysTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Prout test = new Prout();
            Assert.AreEqual(test.Name, "gros cube");
            Assert.AreNotEqual(test.Name, "salut");
        }
    }
}