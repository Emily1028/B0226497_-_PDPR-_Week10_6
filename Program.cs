using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR _Week10_6");
            Console.WriteLine("1~1000 的質數如下");
            int count = 0;
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        break;

                    }
                    if (i%j ==0&&i==j)
                    {
                        count++;
                        Console.Write("{0}\t",i);

                        if (count % 10 == 0)
                        {
                            Console.WriteLine();

                        }

                    }
                }
            }
            Console.ReadLine();
        }
    }
}
