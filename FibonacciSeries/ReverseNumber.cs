using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class ReverseNumber
    {
        public void Reverse(int num)
        {
            int Reverse = 0;
            while(num>0)
            {
                int Remainder = num % 10;
                Reverse = Reverse *10+ Remainder;
                num /= 10;
            }
            Console.WriteLine(Reverse);
        }
    }
}
