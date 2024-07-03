namespace ProblemsSolving.Level_One
{
    /*
    * #10
    * DESCRIPTION:
    * 
    * Write function RemoveExclamationMarks which removes all 
    * exclamation marks from a given string.
    *
    * link : https://www.codewars.com/kata/57a0885cbb9944e24c00008e
    * 
    */
    public class RemoveExclamationMarks
    {
        public  string remove_exclamation_marks(string str)
        {

            string clean = "";
            for (int i = 0;i<str.Length;i++)
            {
                if (str[i] == '!')
                {
                    continue;
                }
                clean += str[i];
            }
            return clean;
        }

        //  public static string RemoveExclamationMarks(string s) => s.Replace("!", string.Empty);

    }
}
