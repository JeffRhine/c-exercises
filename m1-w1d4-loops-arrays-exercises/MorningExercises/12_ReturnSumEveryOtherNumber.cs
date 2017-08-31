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
        12. We want this loop to only count every other item starting at zero. What needs to change in the loop for it to do that?
        */
        public bool ReturnSumEveryOtherNumber()
        {
            int[] arrayToLoopThrough = { 4, 3, 4, 1, 4, 6 };

            int sum = 0;

            //     Start;       Keep going while       Increment by;
            for (int i = 0; i < arrayToLoopThrough.Length; i = i + 1)
            {
                sum = sum + arrayToLoopThrough[i];
            }

            return (sum == 12);
        }
    }
}
