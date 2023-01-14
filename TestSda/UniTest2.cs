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
        private Task1 test { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            test = new Task1();
        }
    }
}
