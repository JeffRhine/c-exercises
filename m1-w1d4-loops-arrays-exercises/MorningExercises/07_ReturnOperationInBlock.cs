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
        7. What will the variable result be at the end of the method? Change the number in the logic expression so that it returns true.
        */
        public bool ReturnOperationInBlock()
        {
            int result = 5;

            {
                int multiplier = 10;
                result *= multiplier;
            }

            return (result == 1); // <-- Change the number to match result and make this be true
        }
    }
}
