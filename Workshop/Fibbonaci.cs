using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class Fibbonaci
    {

        public  static void Fibo()
        {
            Console.WriteLine("enter how much you want to see Fibo ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 1;
            Console.WriteLine("{0} {1}", a, b);
            for (int i = 2; i < num;i++)
            {
                c = a + b;
                Console.Write(" {0} ", c);
                a = b;
                b = c;
            }
        }
    }
}
