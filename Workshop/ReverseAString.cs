using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class ReverseAString
    {
        public static void ReverseString()
        {
            Console.WriteLine("enter a string ");
            string Input = Console.ReadLine();
            char[] charArray = Input.ToCharArray();
            string reversedString = String.Empty;
            for (int i = charArray.Length - 1; i >=0; i--)
            {
                reversedString += charArray[i];


                
            }
            Console.WriteLine("reverse string is  " + reversedString);
   
        }
    }
}
