using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdaClass2
{
    public class Task2
    {
        public static int Fibonacci(int index)
        {
            if (index == 0)
                return 0;

            if (index == 1)
                return 1;

            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            if (index > 40)
                throw new ArgumentOutOfRangeException(nameof(index));

            return Fibonacci(index - 1) + Fibonacci(index - 2);
        }

    }
}
