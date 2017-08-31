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
        6. Here, a variable is defined within a block. How can we get the value of that outside of the block in order to return it? There are a couple of different ways of doing this, what can you come up with?
        */
        public int ReturnVariableFromBlock(int number)
        {

            { // A new block with scoped variables

                int result = number * 5;

            } // the result variable disappears here

            return number; // We want to return result here. How?
        }
    }
}
