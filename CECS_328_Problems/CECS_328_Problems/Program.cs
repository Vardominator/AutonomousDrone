using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CECS_328_Problems
{
    class Program
    {


        delegate void del(int[] array, int index1, int index2);

        // Maximum susequence sum
        static void Main(string[] args)
        {

            
            
            int[] array = {2,8,7,1,3,5,6,4};



            // Sophomore algorithm; O(n^2) time
            int currentSum = 0;
            int maxSum = Int16.MinValue;
            
            for (int boob = 0; boob < array.Length; boob++)
            {

                currentSum = 0;

                for (int j = boob; j < array.Length; j++)
                {
                    currentSum += array[j];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }

            }

            //Console.WriteLine(maximumSubSequence(array, 0, array.Length, maxSum));



            // Random partition function
            int p = 0;
            int r = array.Length - 1;
            int pivot = array[r];

            int i = p - 1;

            del swap = (int[] arr, int i1, int i2) => { int temp = arr[i1]; arr[i1] = arr[i2]; arr[i2] = temp; };

            // Put all values that are less than the pivot to the left side
            for (int j = p; j < r; j++)
            {
                
                if(array[j] <= array[r])
                {
                    i++;
                    swap(array, i, j);
                }    

            }
            // Place the pivot value between the values that are lower than it and the values that are higher than it
            swap(array, i + 1, r);


            for (int apply = 0; apply < array.Length; apply++)
            {

                Console.WriteLine(array[apply]);

            }

        }


        // Junior algorithm: divide & conquer; O(nlogn) time
        public static int maximumSubSequence(int[] array, int start, int end, int maxValue)
        {

            if (start < end)
            {

                int entireSum = 0;

                for (int index = start; index < end; index++)
                {
                    entireSum += array[index];
                }

                if(entireSum > maxValue)
                {
                    maxValue = entireSum;
                }

                int mid = (end + start) / 2;

                int leftHalfSum = maximumSubSequence(array, start, mid, maxValue);
                if(leftHalfSum > maxValue)
                {
                    maxValue = leftHalfSum;
                }

                int secondHalfSum = maximumSubSequence(array, mid + 1, end, maxValue);
                if(secondHalfSum > maxValue)
                {
                    maxValue = secondHalfSum;
                }

            }

            return maxValue;

        }

    }
}
