using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class ReverseANumber
    {
        public static void ReverseAnumber()
        {
            Console.WriteLine("enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while(num >0 )
            {
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;

            }

            Console.WriteLine("reverse of number is   ");

            Console.Write("{0}", rev);

        }
    }
}
