using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

/*
 * * Binary Search
 * Binary search is a fast and efficient searching algorithm used to find a target 
 * value within a sorted array. It works by repeatedly dividing the search interval
 * in half. At each step, it compares the target value with the middle element of 
 * the array. If the target value matches the middle element, the search is successful. 
 * If the target value is less than the middle element, the search continues on the lower 
 * half of the array. If the target value is greater than the middle element, the search 
 * continues on the upper half of the array. This process continues until the target value 
 * is found or until the search interval is empty.
 * 
 * * Pseudocode
 * BinarySearch(array, target):
    left = 0
    right = length of array - 1
    while left <= right:
        mid = (left + right) / 2
        if array[mid] equals target:
            return mid
        else if array[mid] < target:
            left = mid + 1
        else:
            right = mid - 1
    return "Not found"
*/


namespace Search_algorithms
{
    public class Binary
    {
        public static int Binary(int[] theArray, int target) {
            int left = 0;
            int right = theArray.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (theArray[mid] == target)
                {
                    return mid;
                }
                else if (theArray[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    left = mid - 1;
                }
            }
            return -1;
        }
    }
}
