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
          12. Where can I add a ++ to make the result equal 4?
          */
        public int ReturnFourUsingPlusPlus()
        {
            int number = 0;
            return number + number++ + ++number;
        }
    }
}
