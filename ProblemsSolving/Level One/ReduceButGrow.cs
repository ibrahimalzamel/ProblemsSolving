using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Level_One
{
    /*
     * #13
     * DESCRIPTION:
     * 
     * Given a non-empty array of integers, 
     * return the result of multiplying the values together in order. Example:
     * 
     * [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
     * 
     */
    public class ReduceButGrow
    {
        public int Grow(int[] numbers)
        {
            int sum = 1;
            for (int i = 0 ; i < numbers.Length ; i++)
            {
                sum *= numbers[i];
            }
            return sum;
        }
    }
}
