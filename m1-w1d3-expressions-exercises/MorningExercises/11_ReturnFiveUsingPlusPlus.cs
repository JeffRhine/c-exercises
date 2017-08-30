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
           11. ++ and -- increments and decrements by 1. But we can put them at the
           beginning and at the end. What's the difference?
           Where can I add a ++ to make the result equal 5?
           */
        public int ReturnFiveUsingPlusPlus()
        {
            int number = 0;
            return number + number++ + ++number;
        }
    }
}
