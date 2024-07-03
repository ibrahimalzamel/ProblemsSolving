namespace ProblemsSolving.Level_One
{
    /*
    * #8
    * DESCRIPTION:
    * 
    * Given a month as an integer from 1 to 12, 
    * return to which quarter of the year it belongs as an integer number.
    * 
    * For example: 
    * month 2 (February),is part of the first quarter; 
    * month 6 (June), is part of the second quarter; 
    * and month 11 (November), is part of the fourth quarter.
    * 
    * link : https://www.codewars.com/kata/5ce9c1000bab0b001134f5af
    * 
    */

    //1-3 1
    //4-6 2
    //7-9 3
    //10-12 4
    public class QuarterOfYear
    {

        public int quarter_of_year(int month)
        {
            //if (month <= 3)
            //{
            //    return 1;
            //}else if (month > 3 && month <= 6)
            //{
            //    return 2;
            //}

            //else if (month > 6 && month <= 9)
            //{
            //    return 3;
            //}else
            //{
            //    return 4;
            //}
            return month <= 3 ?1 : month <= 6 ?2 : month <= 9 ?3 : 4;
        }
    }
}
