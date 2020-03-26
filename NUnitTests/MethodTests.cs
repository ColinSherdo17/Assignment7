using NUnit.Framework;
using DbAssignment6;
using System;


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
        public void TestPermit()
        {
            

            BusinessMethods Bus = new BusinessMethods();

            Bus.CalculatePermits();
            Console.WriteLine("Testing for Permit Status")
            

            
            
            
        }
    }
}