using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Level_One
{
    /*
    * #23
    * DESCRIPTION:
    * 
    * Consider an array/list of sheep where some sheep may be missing from their place. 
    * We need a function that counts the number of sheep present in the array (true means present).
    * 
    * Examples: 
    * 
    * [true,  true,  true,  false,
    * true,  true,  true,  true ,
    * true,  false, true,  false,
    * true,  false, false, true ,
    * true,  true,  true,  true ,
    * false, false, true,  true]
    * 
    * The correct answer would be 17.
    * Hint: Don't forget to check for bad values like null/undefined
    * 
    * link : https://www.codewars.com/kata/54edbc7200b811e956000556
    * 
    */
    public class CountingSheep
    {
        public  int CountSheeps(bool[] sheeps)
        {
            int counter = 0;
            foreach (bool sheep in sheeps)
            {
                if (sheep)
                {
                    counter++;
                }
            }
            return counter;
            //  return sheeps.Count(s => s);

            //for (int i = 0;i<sheeps.Length;i++)
            //{
            //    if (sheeps[i])
            //    {
            //        counter++;
            //    }
            //}
        }
    }
}
