using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningExercises
{
    public partial class MorningExercise
    {
        /*
          10. This method will take a number and do the following things to it:
          * If addThree is true, we'll add three to that number
          * If addFive is true, we'll add five to that number
          * We'll then return the result
          */
        public int ReturnNumberAfterAddThreeAndAddFive(int number, bool addThree, bool addFive)
        {
            if (addThree)
            {
                number = number + 1;
            }

            // We can't use an else here. They could both be true, so we have to check each one.

            if (addFive)
            {
                number += 1;
            }

            return number;
        }
    }
}
