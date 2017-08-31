using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningExercises
{
    public partial class Exercise
    {

        /*
        9. How many times do we go through this loop? Change the number in the logic expression so that it returns true.
        */
        public bool ReturnCounterFromLoop()
        {

            int[] arrayToLoopThrough = { 3, 4, 2, 9 };

            int counter = 0; // Must be started outside the block so that have access to it after the block

            for (int i = 0; i < arrayToLoopThrough.Length; i++)
            {
                counter++;
            }

            return (counter == 1); // What should the number be to return true?
        }
    }
}
