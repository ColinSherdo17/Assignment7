using NUnit.Framework;
using DbAssignment6;
using System;
using System.Collections.Generic;


namespace NUnitTests
{
    [TestFixture]
    public class MethodTests
    {

        [SetUp]
        public void Test1()
        {
        }
        [Test]
        public void TestFees()
        {

            BusinessMethods Bus = new BusinessMethods();

            double Cost = Bus.AdditionalFees(500);
            
            Console.WriteLine("Testing Additional Fees");
            Assert.AreEqual(550, Cost); 
        }

        [Test]

        public void TestFailFees()
        {
            BusinessMethods Bus = new BusinessMethods();
            double cost = Bus.AdditionalFees(400);
            Console.WriteLine("Testing Additional Fees");
             Assert.AreEqual(460, cost);

        }

       
    }
}