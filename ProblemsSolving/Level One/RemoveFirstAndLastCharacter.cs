using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Level_One
{
    /*
     * DESCRIPTION:
     * 
     * It's pretty straightforward. 
     * Your goal is to create a function that removes the first and last characters of a string. 
     * You're given one parameter, the original string. 
     * You don't have to worry about strings with less than two characters.
     * 
     * link: https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0
     */
    public class RemoveFirstAndLastCharacter
    {
        public  string Remove_char(string s)
        {
            string str = "";
            for (int i = 1;i < s.Length-1; i++) 
            {
                str += s[i];
            }

            return str;
        }
    }
}
