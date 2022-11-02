using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class PrimeNumber
    {
        public void CheckPrime(int num)
        {
            int count = 0;
            for(int i= 1; i <= num; i++)
            {
                if(num%i==0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine("num is prinmeNumber");
            else
                Console.WriteLine("Num is not prime number");
        }
    }
}
