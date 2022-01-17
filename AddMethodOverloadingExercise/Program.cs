using System;

namespace AddMethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(12, 24));
            Console.WriteLine(Add(6.132013m, 23.134340m));
            Console.WriteLine(Add(0, -1, true));  
        }

        public static int Add(int x, int y) // Create a method named Add, that accepts two integers and returns the sum of those two integers
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y) //Now create an overload of the Add method to account for being able to add two decimals together
        {
                 return x + y;
        }

        /*Now create an overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
       If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” 
       at the end of the string.

       You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
     */

        public static string Add(int x, int y, bool shouldDisplayCurrency)
        {
            if (shouldDisplayCurrency == true && x + y == 1)
            {
                return ($"{x + y} dollar");
            }
            else if (shouldDisplayCurrency == true)
            {
                return ($"{x + y} dollars");
            }
            else
                return ($"{x + y}");

        }


        /*public static string Add(int x, int y, bool iscorrect)
        {
            if (iscorrect == true && x + y == 1)
            {
                return ($"{x + y} dollar");
            }
            else if (iscorrect == true && x + y > 1)
            {
                return ($"{x + y} dollars");
            }
            else if (iscorrect == true && x + y == 0)
            {
                return ($"{x + y} dollars");
            }
            else
                return ($"{x + y}");

        }*/
    

        /*public static string Add(int addend1, int addend2, bool shouldDisplayCurrency)
        {
            var sum = addend1 + addend2;

            if (!shouldDisplayCurrency)
                return sum.ToString();

            return $"{sum} dollar{(sum == 1 ? "" : "s")}";
        }*/

       
    }


}
