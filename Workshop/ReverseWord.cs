using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
     
    public class ReverseWord
    {
        public static void ReverseAWord()
        {
            string InputStr, OutputStr = string.Empty;
            Console.WriteLine("enter a string");
            InputStr = Console.ReadLine();
            foreach(var ch in InputStr.Split(' '))
            {
                string temp = "";
                foreach(var chm in ch.ToCharArray())
                {
                    temp = chm + temp;
                }
                OutputStr = OutputStr + temp + " ";

            }
            Console.WriteLine("string is -- " + OutputStr);
          
            
        }
    }
}
