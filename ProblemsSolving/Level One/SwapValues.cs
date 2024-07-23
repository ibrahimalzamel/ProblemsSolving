using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Level_One
{
    /*
     * 28
     * DESCRIPTION:
     * 
     * I would like to be able to pass an array with two elements to my 
     * swapValues function to swap the values. 
     * However it appears that the values aren't changing.
     * 
     * Can you figure out what's wrong here?
     * 
     * link : https://www.codewars.com/kata/5388f0e00b24c5635e000fc6
     * **/
    public class SwapValues
    {
        public object[] Arguments { get; private set; }

        public SwapValues(object[] args)
        {
            Arguments = args;
        }

        public void Swap_Values()
        {
            object[] args = new[] { Arguments[0], Arguments[1] };

            object temp = Arguments[0];
            Arguments[0] = Arguments[1];
            Arguments[1] = temp;
        }
    }
}
