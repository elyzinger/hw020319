using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp a = new Camp(3, 2, 3);
            Camp b = new Camp(6, 3, 4);
            if (a > b)
            {
                Console.WriteLine($"camp a is bigger");
            }
            else
                Console.WriteLine($"camp b is bigger");
            Console.WriteLine(b > a);
            Camp c = new Camp(a + b);
        }
    }
}
