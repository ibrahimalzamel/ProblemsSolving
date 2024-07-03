namespace ProblemsSolving.Level_One
{
    /*
    * #4
    * DESCRIPTION:
    * 
    * Create a function that takes an integer as an argument and returns 
    * "Even" for even numbers or "Odd" for odd numbers.
    * 
    * link : https://www.codewars.com/kata/53da3dbb4a5168369a0000fe
    * 
    */

    public class EvenOrOdd
    {
        public string even_or_odd(int number)
        {
            return number % 2 == 0 ? "Even":"Odd";
        }
        //public static string EvenOrOdd(int number)=> number % 2 == 0 ? "Even" : "Odd";
    }
}
