using System;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }

        [Test]
        public void Test2()
        {
            Console.Write("Hello CShap Unit Test");
        }
    }
}