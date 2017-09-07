using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * STRINGS!!
         * Just when you thought it was safe to get back in the water --- last2Revisited!!!!
         * 
         * Given an array of strings, for each string, store the count of the number of times that the last 2 characters 
         * appears in the string. We don't count the end substring so "hixxxhi" yields 1 because "hi" is the end and it appears
         * 1 time in the rest of the string. 
         * 
         * A substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.  
         * 
         * This will allow you to practice
         * - looping through an array of strings
         * - searching for a substring in a string
         * - adding key-value-pairs to a dictionary
         * 
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *  
         * last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         * 
         */
        public Dictionary<string, int> Last2Revisted(string[] words)
        {
            return null;
        }
    }
}
