using System;
using System.Diagnostics;
using NUnit.Framework;

namespace hello
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Hello World");
            Debug.WriteLine("start up");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Hello World");
            Debug.WriteLine("test info");
            Assert.Pass();
        }
    }
}