using NUnit.Framework;
using System;
using testapp.Base;

namespace testapp
{
    public class Tests:TestBase
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown]
        public void TestTearDownBaseClass()
        {
            Console.WriteLine("derived tear down");
        }
    }
}