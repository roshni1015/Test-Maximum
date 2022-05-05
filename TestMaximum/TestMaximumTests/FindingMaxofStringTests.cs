using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum.Tests
{
    [TestClass()]
    public class FindingMaxofStringTests
    {
        [TestMethod()]
        public void MaxValueStringsTest()
        {
            FindingMaxofString find = new FindingMaxofString();
            string x = find.MaxValueStrings("Elephant", "Mango", "bat");
            Assert.AreEqual("Elephant", x);
        }
        [TestMethod()]
        public void MaxValueStringsTest2()
        {
            FindingMaxofString find = new FindingMaxofString();
            string x = find.MaxValueStrings("Mango", "Elephant", "bat");
            Assert.AreEqual("Elephant", x);
        }
        [TestMethod()]
        public void MaxValueStringsTest3()
        {
            FindingMaxofString find = new FindingMaxofString();
            string x = find.MaxValueStrings("bat", "Mango", "Elephant");
            Assert.AreEqual("Elephant", x);
        }
    }
}