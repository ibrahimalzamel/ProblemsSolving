﻿namespace ProblemsSolving.Level_One
{
    /*
    * #9
    * DESCRIPTION:
    * Given a set of numbers, return the additive inverse of each. 
    * Each positive becomes negatives, and the negatives become positives.
    * 
    * [1, 2, 3, 4, 5] --> [-1, -2, -3, -4, -5]
    * [1, -2, 3, -4, 5] --> [-1, 2, -3, 4, -5]
    * [] --> []
    * 
    * You can assume that all values are integers. Do not mutate the input array.
    * 
    * link : https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad
    * 
    */
    public class InvertValues
    {
        public  int[] invert_values(int[] input)
        {
            for (int i = 0;i<input.Length;i++)
            {
                 input[i] *= -1;
            }
            return input;
            //Code it!
        }
    }
}
