using NUnit.Framework;
using SDAclass3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSda
{
    public class UnitTest4
    {    //jemi tek A(AKSES) e pare 
        private Task4 test { get; set; } = null;
        public TestContext TestContext { get; set; }

        [SetUp]
        public void Setup()
        {
            test = new Task4();
        }

        [Test]
        public void kontrolloEmerFajli()
        {
            string fileName= @"C:\Windows\regedit.exe";

           var response= test.FileExists(fileName);

            Assert.IsTrue(response);
        }

    }
}
