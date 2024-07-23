using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Level_One
{
    /*
     * 29
     * DESCRIPTION:
     * Kids drink toddy.
     * Teens drink coke.
     * Young adults drink beer.
     * Adults drink whisky.
     * Make a function that receive age, and return what they drink.
     * 
     * Rules:
     * 
     * Children under 14 old.
     * Teens under 18 old.
     * Young under 21 old.
     * Adults have 21 or more.
     * 
     * Examples: (Input --> Output)
     * 
     * 13 --> "drink toddy"
     * 17 --> "drink coke"
     * 18 --> "drink beer"
     * 20 --> "drink beer"
     * 30 --> "drink whisky"
     * 
     * **/
    public class DrinkAbout
    {
        public  string PeopleWithAgeDrink(int old)
        {
            return "drink " + (old < 14 ? "toddy" : old < 18 ? "coke" : old < 21 ? "beer" : "whisky");
        }
    }
}
