using NUnit.Framework;
using DbAssignment6;
using System;
using System.Collections.Generic;



namespace NUnitTests
{
    //Test fixture showing the class contains test methods
    [TestFixture]
    public class MethodTests
    { 
    
        //ignore Test to ignore the Test Case Fails Test
        [Test]
        [Ignore("Ignore this Test")]
        public void TestCaseFails()
        {

        }

        //Test Case to hold the Tests
        [TestCase]
        [SetUp]
        public void Test1()
        {
        }
        //Test to check if my AdditionalFees method is working as expected
        [Test]
        public void TestFees()
        {
        //New business method reference
            BusinessMethods Bus = new BusinessMethods();

        //Calls the method against a test variable
            double Cost = Bus.AdditionalFees(500);

            Console.WriteLine("Testing Additional Fees");
        //uses Assert.AreEqual to make sure the method returns the same as what is expected from the test
            Assert.AreEqual(550, Cost);
        }

        //TimeOut Tests to check robustness
        [Test]
        [Timeout(4000)]
        public void TimeTest()
        {
        }

        //Failed Test to check my AdditionalFees method is working
        [Test]
        public void TestFailFees()
        {
            BusinessMethods Bus = new BusinessMethods();
            double cost = Bus.AdditionalFees(400);
            Console.WriteLine("Testing Additional Fees");

            //The expected here is wrong to the actual answer which will cause the Test to fail
            Assert.AreEqual(460, cost);

        }

        [Test]
        [MaxTime(2000)]
        public void MaxTime()
        {
        }

       
    }
    
}