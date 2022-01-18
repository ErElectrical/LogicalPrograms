using System;

namespace Workshop
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To workshop");
            start:

            Console.WriteLine("\n 1. Fibo series" +
                "\n 2. Reverse a number" +
                "\n 3. String Plaindrome" +
                "\n 4. Number Plaindrome" +
                "\n 5. Highest Number in array" +
                "\n 6. Reverse a string " +
                "\n 7. Reverse a word");
            Console.WriteLine("enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        Fibbonaci.Fibo();
                        break;

                    }
                case 2:
                    {
                        ReverseANumber.ReverseAnumber();
                        break;

                    }
                case 3:
                    {
                        StringPlaindrome.PlaindromeChecker();
                        break;

                    }
                case 4:
                    {
                        NumberPlaindrome.Plaindrome_Chexker();
                        break;

                    }
                case 5:
                    {
                        HighestNumberInArray.HighestNumber();
                        break;

                    }
                case 6:
                    {
                        ReverseAString.ReverseString();
                        break;

                    }
                case 7:
                    {
                        ReverseWord.ReverseAWord();
                        break;

                    }
                default:
                    {
                        Console.WriteLine("enter correct choice");
                        goto start;
                        break;
                    }
            }
            


        }
    }
}

/* 
 * fibonacci
reverse the numbers
string Palindrome
Number Palindrome
Highest NUmber from an array
reverse the string "hi hello" to "olleh ih"
reverse the words only "hi hello" to "ih olleh"
RFP_DotNet New Fellowship - 092 */