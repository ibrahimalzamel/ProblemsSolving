namespace ProblemsSolving.Level_One
{
    /*
     * #26
     * DESCRIPTION:
     * 
     * Write a function which calculates the average of the numbers in a given list.
     * 
     * Note: Empty arrays should return 0.
     * link : https://www.codewars.com/kata/57a2013acf1fa5bfc4000921
     */
    public class CalculateAverage
    {
        public double FindAverage(double[] array)
        {
            //return array.Length == 0 ? 0 : array.Average();
         
            double sum = 0;
            double num = 0;
            if (array.Length==0)
            {
                return 0;
            }
            
            foreach (var item in array)
            {
                sum += item;
                num++;
            }

            // Your code here
            return sum/num;
        }
    }
}
