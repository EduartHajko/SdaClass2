using NUnit.Framework;
using SdaClass2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSda
{
    public class UniTest2
    {
        //jemi tek A(AKSES) e pare 
        private Task2 test { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            test = new Task2();
        }
        [Test]
        public  void testFibonaci()
        {
            Assert.AreEqual(0, test.Fibonacci(0));
            Assert.AreEqual(1, test.Fibonacci(1));
            Assert.AreEqual(13, test.Fibonacci(7));
            Assert.Throws<ArgumentOutOfRangeException>(() => { test.Fibonacci(-1); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { test.Fibonacci(int.MaxValue); });
            Assert.DoesNotThrow(() => { test.Fibonacci(40); });
        }
    }
}
