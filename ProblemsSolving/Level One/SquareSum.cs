using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Level_One
{
    /*
    * #24
    * DESCRIPTION:
    * 
    * Complete the square sum function so that it squares each number 
    * passed into it and then sums the results together.
    * 
    * Examples: 
    * 
    * For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9
    * 
    * link : https://www.codewars.com/kata/515e271a311df0350d00000f
    * 
    */
    public class SquareSum
    {
        public int squareSum(int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number*number;
            }
            return result; 
        }
        //  public static int SquareSum(int[] n) => n.Sum(i => i * i);
        //  return n.Sum(x => x*x);

    }
}
