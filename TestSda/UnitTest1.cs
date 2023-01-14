using NUnit.Framework;
using SdaClass2;

namespace TestSda
{
    public class Tests
    {
        //jemi tek A(AKSES) e pare 
        private Task1 test { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            test = new Task1();
        }
        [TestCase(34)]
        [TestCase(45)]
        [TestCase(55)]
        [TestCase(56)]
        [TestCase(80)]
        //dua te testoj noten
        //metoda nuk ka parameter
        public void DuaTeTEstojNotenMultiple(int grade)
        {
            //Kjo eshte A e dyte (Act)
             //= 55;

            var result = test.getGrades(grade);

            //kjo eshte A e trete (ASSERT)

            Assert.AreSame("A", result);   

            
        }
       
        [Test]
        //dua te testoj noten
        //metoda nuk ka parameter
        public void DuaTeTEstojNoten()
        {
            //Kjo eshte A e dyte (Act)
            int grade = 55;

            var result = test.getGrades(grade);

            //kjo eshte A e trete (ASSERT)

            Assert.AreSame("A", result);

        }
    }
}