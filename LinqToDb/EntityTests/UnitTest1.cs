using System;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var customers = CustomerDbMethods.GetCustomers();
        }
    }
}
