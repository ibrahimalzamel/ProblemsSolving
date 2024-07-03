using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Level_One
{
    /*
    * #6
    * DESCRIPTION:
    * 
    * Implement a function which convert the given boolean value into its string representation.
    * Note: Only valid inputs will be given.
    * 
    * link : https://www.codewars.com/kata/551b4501ac0447318f0009cd
    * 
    */
    public class ConvertBooleanToString
    {
        public string BooleanToString(bool b)
        {
            return b ? "True" : "False";
        }
    }
}
