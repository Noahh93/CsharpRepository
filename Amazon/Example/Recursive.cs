using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example
{
    internal class Recursive
    {
        /*
        //recursive function
        public void DisplayArray(int[] arr, int length)
        {
            if (length <= 0)
            {
                return;
            }

            length = length - 1;
            DisplayArray(arr, length);
            Console.WriteLine(arr[length]);
        }
        */

        //Create a recursive function and write
        //sum 1 +2 +3 + 4+ until range (10)
        public int SumofRange(int range)
        {
            while (range <= 10 && range >= 0)
            {
                return range--;
            }

            Console.WriteLine(SumofRange(range));
            return range;
        }






        public void DisplayArray(int[] Array)
        {


            int index = 0;
            int sum = 0;
            int firstHalf = 0;
            int midIndex = Array.Length/2;


            while (Array.Length > 0 )
            {
                sum = sum + Array[index];
                index++;
                if (index > midIndex)
                {
                    break;
                }


            }

            int sum2 = 0;

            while (Array.Length > 0 )
            {
                sum2 = sum2 + Array[midIndex];
                midIndex++;
                if (midIndex == Array.Length)
                {
                    break;
                }
            }


            Console.WriteLine($"First half = {sum}");
            Console.WriteLine($"Second half = {sum2}");
        }

        public void DisplaySum(int length)
        {

            int i = 1;
            int sum = 0;

            while (length > 0)
            {
                sum = sum + i;
                i++;
                if (i > length)
                {
                    break;
                }

            }
            Console.WriteLine(sum);
        }










        /*






            public void DisplayArray(int[] arr, int length)
        {
            if (length < 0)
            {
                return;
            }
            Console.WriteLine(arr[length]);
            length = length - 1;
            DisplayArray(arr, length);

        }
        */
    }
}
