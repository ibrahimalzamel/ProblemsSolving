namespace ProblemsSolving.Level_One
{
    /*
     * #17
     * DESCRIPTION:
     * 
     * Create a function that accepts a string and a single character, 
     * and returns an integer of the count of occurrences the 2nd argument is found in the first one.
     * If no occurrences can be found, a count of 0 should be returned.
     * 
     * ("Hello", 'o')  =>  1
     * ("Hello", 'l')  =>  2
     * ("", 'z')       =>  0
     * 
     * link: https://www.codewars.com/kata/5865918c6b569962950002a1
     */
    public class AllStarCodeChallenge
    {
        public  int StrCount(string str, char letter)
        {
            int count = 0;
            //for (int i = 0;i <str.Length;i++) 
            //{
            //    if (str[i] == letter)
            //    {
            //        count++;
            //    }
            //}
            foreach (char c in str)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }
        //  public static int StrCount(string s, char l) => s.Split(l).Length-1;
        //  return str.Count(a => a.Equals(letter));

    }
}
