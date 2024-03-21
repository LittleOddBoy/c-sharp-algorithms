using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
    Linear Search:
    Linear search is a simple searching algorithm where we iterate through the entire array or
    list to find the target element. It checks each element one by one until the target element
    is found or until the end of the list is reached.

    Pseudocode:
        LinearSearch(array, target):
        for each element in array:
            if element equals target:
                return element's index
        return "Not found"
 */


namespace Search_algorithms 
{ 
    internal class Linear
    {
        public static string LinearSearcher(string[] subjectArray, string target)
        {
            foreach (var subject in subjectArray)
            {
                if (subject.Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    return $"Yep! We've the {target} in our store";
                }
                return $"Pardon me but we don't have {target} in our stack!";
            }
        }

        
    }
}
