using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdaClass2
{
    public  class Task1
    {
        public string getGrades(int grades)
        {
            string nota = "";
            if (grades <= 100 && grades > 90)
                nota = "A";
            else if (grades <= 90 && grades > 80)
                nota="B";
            else if (grades <= 80 && grades > 70)
                nota = "C";
            else if (grades <= 70 && grades > 60)
                nota = "E";
            else if (grades <= 60 && grades > 50)
                nota = "F";

            return nota;
        }
    }
}
