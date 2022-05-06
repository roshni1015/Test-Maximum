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
    public class CreateGenericClassTests
    {
        [TestMethod()]
        public void CreateGenericClassTest()
        {

            int x = CreateGenericClass<int>.MaxValueGeneric<int>(100, 75, 40);
            Assert.AreEqual(100, x);
        }
        [TestMethod()]
        public void CreateGenericClassTest2()
        {

            double x = CreateGenericClass<double>.MaxValueGeneric<double>(50.3, 35.5, 20.6);
            Assert.AreEqual(50.3, x);
        }
        [TestMethod()]
        public void CreateGenericClassTest3()
        {

            string x = CreateGenericClass<string>.MaxValueGeneric<string>("Bananas", "Animal", "Apple");
            Assert.AreEqual("Bananas", x);
        }
    }
}