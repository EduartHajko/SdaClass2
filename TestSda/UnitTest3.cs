using NUnit.Framework;
using SdaClass2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSda
{
    public class UnitTest3
    {
        //jemi tek A(AKSES) e pare 
        private Task3 test { get; set; } = null;
        public TestContext TestContext { get; set; }

        [SetUp]
        public void Setup()
        {
            test = new Task3();
        }
        [Test]
        public void TestFileExists()
        {
            TestContext.WriteLine("kemi aksesuar metoden me sukses");

            Assert.Throws<FileNotFoundException>(() => { test.CopyFile("edi.exe","test"); });
        }

        [Test]
        public void TestFileNonExists()
        {
            Assert.DoesNotThrow(() => { test.CopyFile("edi.exe", null); });
           
        }

        [Test]
        public void TestisCorrect()
        {
            
            Assert.DoesNotThrow(() => { test.CopyFile("edi.exe", null); });
        }
        [Test]
        public void TestNotCompiled2()
        {
            Assert.Inconclusive();
        }



    }
}
