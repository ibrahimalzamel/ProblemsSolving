using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Level_One
{
    /*
    * #5
    * DESCRIPTION:
    * 
    * Complete the solution so that it reverses the string passed into it.
    * 'world'  =>  'dlrow'
    * 'word'   =>  'drow'
    * link : https://www.codewars.com/kata/5168bb5dfe9a00b126000018
    * 
    */
    public class ReversedStrings
    {
        public string reversed_strings(string str)
        {
            string reversed = "";
            
            for (int i = str.Length-1;i>=0; i--)
            {
                reversed += str[i];
            }
            return reversed;
        }
    }
}
