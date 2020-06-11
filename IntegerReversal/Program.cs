using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IntegerReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 400;

            int lastDigit = 0;
            int reverse = 0;

            while (number >= 1)
            {
                lastDigit = number % 10;
                reverse = reverse * 10 + lastDigit;
                number = number / 10;
            }

            Console.WriteLine( reverse);
            Console.ReadLine();
        }
    }
}
