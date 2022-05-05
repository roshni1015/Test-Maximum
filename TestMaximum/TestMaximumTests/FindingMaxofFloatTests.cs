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
    public class FindingMaxofFloatTests
    {
        [TestMethod()]
        public void MaxValueIntTest()
        {
            FindingMaxofFloat find = new FindingMaxofFloat();
            double  x = find.MaxValueFloat(4.55, 2.45, 1.05);
            Assert.AreEqual(4.55, x);
        }
        [TestMethod()]
        public void MaxValueIntTest2()
        {
            FindingMaxofFloat find = new FindingMaxofFloat();
            double x = find.MaxValueFloat(2.45, 4.55, 1.05);
            Assert.AreEqual(4.55, x);
        }
        [TestMethod()]
        public void MaxValueIntTest3()
        {
            FindingMaxofFloat find = new FindingMaxofFloat();
            double x = find.MaxValueFloat(1.05, 2.45, 4.55);
            Assert.AreEqual(4.55, x);
        }
    }
}