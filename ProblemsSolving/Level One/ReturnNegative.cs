using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Level_One
{
    /*
     * #27
     * DESCRIPTION:
     * In this simple assignment you are given a number and have to make it negative. But maybe the number is already negative?
     * Examples:
     * Kata.MakeNegative(1);  // return -1
     * Kata.MakeNegative(-5); // return -5
     * Kata.MakeNegative(0);  // return 0
     *
     * Notes
     *
     * The number can be negative already, in which case no change is required.
     * Zero (0) is not checked for any specific sign. 
     * Negative zeros make no mathematical sense.
     * 
     *  link : https://www.codewars.com/kata/55685cd7ad70877c23000102
     */
    public class ReturnNegative
    {
        public  int MakeNegative(int number)
        {
            //if (number > 0)
            //    number *= -1;
            //return number;
            return  number < 0 ? number : -number;            
        }
    }
}

