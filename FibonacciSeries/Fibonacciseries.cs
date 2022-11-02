using System;
namespace BasicCoreprogram
{
    public class FibonacciSeries
    {
        public void Print(int num)
        {
            int firstNum = 0, SecondNum = 1, ThirdNum = 0;
            Console.WriteLine(firstNum + "\n " + SecondNum);
            for (int i = 0; i < num; i++)
            {
                ThirdNum = firstNum + SecondNum;
                firstNum = SecondNum;
                SecondNum = ThirdNum;
                Console.WriteLine(ThirdNum);

            }
        }
    }
}