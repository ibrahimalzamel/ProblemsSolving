namespace ProblemsSolving.Level_One
{
    /*
     * #18
     * DESCRIPTION:
     * 
     * Clock shows h hours, m minutes and s seconds after midnight.
     * Your task is to write a function which returns the time since midnight in milliseconds.
     * Example:
     * 
     * h = 0
     * m = 1
     * s = 1
     * result = 61000
     * 
     * Input constraints:
     * 
     * 0 <= h <= 23
     * 0 <= m <= 59
     * 0 <= s <= 59
     * 
     * link : https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a
     * 
     */
    public class BeginnerSeries
    {
        // s = 1000;
        // m = 60 * 1000;
        // h = 60 * 60 * 1000
        public  int Past(int h, int m, int s)
        {
            return ((h * 60 + m) * 60 + s) * 1000;
            //#Happy Coding! ^_^
        }

        //      return (int)(new TimeSpan(h, m, s)).TotalMilliseconds;

        //  m += h * 60;
        //  s += m* 60;
        //  s *= 1000;
        //  return s;     

    }
}
