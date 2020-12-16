using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag ;
            int k, x;
            Console.WriteLine("Enter 1st Number");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2st Number");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime NUmber are");
            for (int i = k; i <= x; i++)
            {


                if (i == 1 || i == 0)
                    continue;

                flag = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
