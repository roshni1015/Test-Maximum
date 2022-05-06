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
    public class FindingMaxUsingGenericsTests
    {
        [TestMethod()]
        public void MaxValueGenericsTest()
        {

            FindingMaxUsingGenerics find = new FindingMaxUsingGenerics();
            int x = FindingMaxUsingGenerics.MaxValueGenerics<int>(90, 65, 10);
            Assert.AreEqual(90, x);
           
        }
        [TestMethod()]
        public void MaxValueGenericsTest2()
        {

            FindingMaxUsingGenerics find = new FindingMaxUsingGenerics();
            double x = FindingMaxUsingGenerics.MaxValueGenerics<double>(9.50, 7.40, 4.44);
            Assert.AreEqual(9.50, x);

        }
        [TestMethod()]
        public void MaxValueGenericsTest3()
        {

            FindingMaxUsingGenerics find = new FindingMaxUsingGenerics();
            string x = FindingMaxUsingGenerics.MaxValueGenerics<string>("Strawberry", "Birds", "Bottle");
            Assert.AreEqual("Strawberry", x);

        }
    }
}