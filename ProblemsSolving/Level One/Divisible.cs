namespace ProblemsSolving.Level_One
{
    public class Divisible
    {
        public  bool IsDivisible(int n, int x, int y)
        {
            return (n % x == 0 && n % y == 0);
        }
    }
}
