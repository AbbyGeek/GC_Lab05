using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont == true)
            {

                Console.WriteLine("Give me a number from 1-20");
                long FNum = Convert.ToInt64(Console.ReadLine());
                List<long> list = new List<long>();
                long fact = 1;

                long ans = Factorial(FNum);


                for (long i = 1; i <= FNum; i++)
                {
                    long info = 1;
                    list.Add(i);

                    foreach (long x in list)
                    {
                        info *= x;
                    }

                    Console.WriteLine(i + "!= " + string.Join("x", list) + "\t \t \t which equals " + info);
                    fact = ans;
                }


                Console.WriteLine("\n\n The Factorial of " + FNum + " is " + ans);
            
            }
        }

 
        private static long Factorial(long FNum)
        {
            if (FNum == 1)
                return 1;
            return FNum * Factorial(FNum - 1);
        }


    }
}
