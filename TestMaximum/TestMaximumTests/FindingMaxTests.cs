using TestMaximum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMaximum.Tests
{
    [TestClass()]
    public class FindingMaxTests
    {
        [TestMethod()]
        public void MaxValueIntTest()
        {
            FindingMax find = new FindingMax();
            int x = find.MaxValueInt(50, 30, 15);
            Assert.AreEqual(50, x);
        }
        [TestMethod()]
        public void MaxValueIntTest2()
        {
            FindingMax find = new FindingMax();
            int x = find.MaxValueInt(30, 50, 15);
            Assert.AreEqual(50, x);
        }
        [TestMethod()]
        public void MaxValueIntTest3()
        {
            FindingMax find = new FindingMax();
            int x = find.MaxValueInt(15, 30, 50);
            Assert.AreEqual(50, x);
        }
    }
}