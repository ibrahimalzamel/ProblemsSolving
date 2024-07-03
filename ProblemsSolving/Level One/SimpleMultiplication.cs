namespace ProblemsSolving.Level_One
{
    public class SimpleMultiplication
    {
        public int Multiply(int a)
        {
           return a % 2 == 0 ?  a *8 : a*9 ;
        }
      
        // public static int Multiply(int n) => n * (n % 2 == 0 ? 8 : 9);
    }
}
