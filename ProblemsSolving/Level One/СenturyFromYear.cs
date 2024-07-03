namespace ProblemsSolving.Level_One
{
    public class СenturyFromYear
    {
        public int centuryFromYear(int year)
        {
            int a = (year - 1) / 100 + 1;

            return a;
        }
        // public static int СenturyFromYear(int year) => (year - 1) / 100 + 1;
    }
}
