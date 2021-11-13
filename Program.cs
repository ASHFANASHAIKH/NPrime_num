using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPrime_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first N prime numbers are:");
            int noOfPrimeCount = 0, count, num = 2;
            while (noOfPrimeCount < n)
            {
                count = 0;
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                    if (count >= 2)
                    {
                        break;
                    }
                }
                if (count < 2)
                {
                    noOfPrimeCount++;
                    Console.WriteLine(num);
                }
                num++;
            }
        }
    }
    }

