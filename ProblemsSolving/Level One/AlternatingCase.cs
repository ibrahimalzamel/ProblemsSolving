using System.ComponentModel;

namespace ProblemsSolving.Level_One
{
    /*
    * #19
    * DESCRIPTION:
    * 
    * altERnaTIng cAsE <=> ALTerNAtiNG CaSe
    * Define String.prototype.toAlternatingCase 
    * (or a similar function/method such as to_alternating_case/
    * toAlternatingCase/ToAlternatingCase in your selected language; 
    * see the initial solution for details) 
    * such that each lowercase letter becomes uppercase and each uppercase letter becomes lowercase. 
    * 
    * Example:
    * "hello world".ToAlternatingCase() == "HELLO WORLD"
    * link : https://www.codewars.com/kata/56efc695740d30f963000557
    * 
    */
    public class AlternatingCase
    {
        public string ToAlternatingCase( string s)
        {
            string result = "";

            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                {
                    result += Char.ToLower(c);
                }
                else if (Char.IsLower(c))
                {
                    result += Char.ToUpper(c);
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
