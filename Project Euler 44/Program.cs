using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Project_Euler_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] Numbers = new BigInteger[3000];
            for (int n = 0; n < Numbers.Length; n++)
            {
                Numbers[n] = n * (3 * n - 1) / 2;
                //Console.WriteLine(Numbers[n]);
            }
            BigInteger minimum = 1000000000;
            for (int k = 1; k < Numbers.Length; k++)
            {
                BigInteger number = 0;
                BigInteger number2 = 0;
                for (int j = 1; j < Numbers.Length; j++)
                {
                    number = Numbers[k] - Numbers[j];
                    //Console.WriteLine(Numbers[k]);
                    //Console.WriteLine(number);
                    number2 = Numbers[k] + Numbers[j];
                    //Console.WriteLine(Numbers[j]);
                    //Console.WriteLine(number2);
                    if (Numbers.Contains(number) && Numbers.Contains(number2) && number < minimum && number != 0)
                    {
                        minimum = number;
                    }
                }
            }
            Console.WriteLine(minimum);
        }
    }
}
