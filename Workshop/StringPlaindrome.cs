using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class StringPlaindrome
    {
        public static void PlaindromeChecker()
        {
            string InputStr, ReverseStr =String.Empty;
            Console.WriteLine("enter a string : ");
            InputStr = Console.ReadLine();
            if (InputStr != null)
            {
                for (int i = InputStr.Length - 1; i >= 0; i--)
                {
                    ReverseStr += InputStr[i].ToString();
                }
                if (InputStr.Equals( ReverseStr))
                {
                    Console.WriteLine("string is plaindrome");
                }
                else
                {
                    Console.WriteLine("string is not plaindrome");
                }
            }
            Console.ReadLine();
        }
        
     }
}
