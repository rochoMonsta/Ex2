using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        public static int pow (string side)
        {
            int a = Convert.ToInt32(side);
            return a * a;
        }
        static void Main(string[] args)
        {
            string side;
            int squer = 0;

            Console.Write("Enter your side:");
            side = Console.ReadLine();
            squer = pow(side);
            Console.WriteLine("Your pow is:" + squer);
            Console.ReadKey();
        }
    }
}
