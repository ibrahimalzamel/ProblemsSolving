// See https://aka.ms/new-console-template for more information
using ProblemsSolving;
using ProblemsSolving.Level_One;

//#1
SimpleMultiplication simpleMultiplication = new SimpleMultiplication();
int a = simpleMultiplication.Multiply(6); //5
Console.WriteLine(a);

//#2
СenturyFromYear сentury_from_year = new СenturyFromYear();
int b = сentury_from_year.centuryFromYear(1799);//1700  1701
Console.WriteLine(b);

//#3
Divisible divisible = new Divisible();
bool c = divisible.IsDivisible(9, 1, 3);//9 2 3 
Console.WriteLine(c);

