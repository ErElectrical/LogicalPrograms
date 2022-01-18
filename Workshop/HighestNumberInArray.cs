using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public  class HighestNumberInArray
    {
        public static void HighestNumber()
        {

            Console.WriteLine("Enter the length of array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] =Convert.ToInt32 (Console.ReadLine());
            }

            
            

            int max = arr[0];
            for (int j =0;j<arr.Length;j++)
            {
                if (arr[j] > max)
                    max = arr[j];
            }
            Console.WriteLine("Largest number in array is : {0}", max);
        }
    }
}
