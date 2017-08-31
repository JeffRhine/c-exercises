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
        8. Return the only variable that is in scope at the return statement.
        */
        public double ReturnInScopeVariable()
        {
            double one = 1.0;
            {
                double three = 3.0;
                one += three;
                {
                    double four = 4.0;
                    three = four - one;
                    one++;
                }

                double five = 5.0;
                double eight = five + three;
            }

            return 0;
        }
    }
}
