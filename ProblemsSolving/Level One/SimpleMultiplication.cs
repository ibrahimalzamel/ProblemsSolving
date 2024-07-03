namespace ProblemsSolving.Level_One
{
    /*
     * #1
     * DESCRIPTION:
     * 
     * This kata is about multiplying a given number 
     * by eightif it is an even number and by nine otherwise.
     * 
     * link : https://www.codewars.com/kata/583710ccaa6717322c000105
     * 
     */
    public class SimpleMultiplication
    {
        public int Multiply(int a)
        {
           return a % 2 == 0 ?  a *8 : a*9 ;
        }
      
        // public static int Multiply(int n) => n * (n % 2 == 0 ? 8 : 9);
    }
}
