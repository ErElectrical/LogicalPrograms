using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class NumberPlaindrome
    {
        public static void Plaindrome_Chexker()
        {
            Console.WriteLine("Enter A number");
            int num = Convert.ToInt32(Console.ReadLine());
            int record = num;
            int rev = 0;
            while(num > 0)
            {
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;
            }
            if(record == rev)
            {
                Console.WriteLine("Number is Plaindrome");
            }
            else
            {
                Console.WriteLine("number is not Plaindrome");
            }
        }
    }
}
