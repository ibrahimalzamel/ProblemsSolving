// See https://aka.ms/new-console-template for more information
using ProblemsSolving;
using ProblemsSolving.Level_One;

//#1
SimpleMultiplication simpleMultiplication = new SimpleMultiplication();
int a = simpleMultiplication.Multiply(6); //5
Console.WriteLine("#1 " + a);

//#2
СenturyFromYear сentury_from_year = new СenturyFromYear();
int b = сentury_from_year.centuryFromYear(1799);//1700  1701
Console.WriteLine("#2 " + b);

//#3
Divisible divisible = new Divisible();
bool c = divisible.IsDivisible(9, 1, 3);//9 2 3 
Console.WriteLine("#3 " + c);

//#4
EvenOrOdd evenOrOdd = new EvenOrOdd();
string even_or_odd = evenOrOdd.even_or_odd(4);
Console.WriteLine("#4 " + even_or_odd);

//#5
ReversedStrings reversedStrings = new ReversedStrings();
string str = reversedStrings.reversed_strings("world");
Console.WriteLine("#5 " + str);

//#6
ConvertBooleanToString convertBooleanToString = new ConvertBooleanToString();
string d = convertBooleanToString.BooleanToString(false);
Console.WriteLine("#6 " + d);

//#7
PriceOfMangoes priceOfMangoes = new PriceOfMangoes();
int total = priceOfMangoes.Mango(8, 5);
Console.WriteLine("#7 "+total);

//#8
QuarterOfYear quarterOfYear = new QuarterOfYear();
int quarter = quarterOfYear.quarter_of_year(9);
Console.WriteLine("#8 " + quarter);

//#9
InvertValues invertValues = new InvertValues();
int[]  numbers = invertValues.invert_values([1, 2, 3, 4, 5]);
Console.Write("#9 ");
foreach (int number in numbers)
{
    Console.Write( number +" ");
}
Console.WriteLine();

//#10
RemoveExclamationMarks removeExclamationMarks = new RemoveExclamationMarks();
string removeMark = removeExclamationMarks.remove_exclamation_marks("Hello !!! World!!!");
Console.WriteLine("#10 "+removeMark);

//#11
FindMaxMiniValuesOfList findMaxMiniValues = new FindMaxMiniValuesOfList();
int max = findMaxMiniValues.MaxValuesOfList([4, 6, 2, 1, 9, 63, -134, 566]); 
int mini = findMaxMiniValues.MiniValuesOfList([4, 6, 2, 1, 9, 63, -134, 566]);
Console.WriteLine("#11 "+"Max:" + max + " Mini:" + mini);

//#12
KeepHydrated keepHydrated  = new KeepHydrated();
int litre = keepHydrated.Litres(11.8);
Console.WriteLine(litre);

//#13
ReduceButGrow reduceButGrow = new ReduceButGrow();
int sum = reduceButGrow.Grow([1, 2, 3, 4]);
Console.WriteLine(sum);

//#13

//#14

//#15

//#16

//#17

//#18

//#19

//#20

//#21

//#22

//#23
//#24
//#25
//#26
//#27
//#28
//#29
//#30
//#31
