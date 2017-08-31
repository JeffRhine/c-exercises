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
        11. This loop is counting incorrectly. What needs to change in the loop for it to count properly?
        */
        public bool ReturnCountCorrectTimes()
        {
            int[] arrayToLoopThrough = { 4, 23, 9, 4, 33 };

            int counter = 0;

            //     Start;       Keep going while         Increment by one;
            for (int i = 0; i <= arrayToLoopThrough.Length; i++)
            {
                counter = counter + 1;
            }

            return (counter == 5);
        }
    }
}
