// See https://aka.ms/new-console-template for more information
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
Console.WriteLine("#12 " + litre);

//#13
ReduceButGrow reduceButGrow = new ReduceButGrow();
int sum = reduceButGrow.Grow([1, 2, 3, 4]);
Console.WriteLine("#13 " + sum);

//#14
RemoveFirstAndLastCharacter removeFirstAndLastCharacter = new RemoveFirstAndLastCharacter();
string str1 = removeFirstAndLastCharacter.Remove_char("ibrahim");
Console.WriteLine("#14 " + str1);

//#15
StringRepeat stringRepeat = new StringRepeat();
string res = stringRepeat.RepeatStr(5, "ibrahim");
Console.WriteLine("#15 " + res);

//#16
RemoveStringSpaces removeStringSpaces = new RemoveStringSpaces();
string removeSpaces = removeStringSpaces.NoSpace("ibra him alz am el 19 96");
Console.WriteLine("#16 " + removeSpaces);

//#17
AllStarCodeChallenge allStarCodeChallenge = new AllStarCodeChallenge();
int strCountChar = allStarCodeChallenge.StrCount("ibrahim elzamil", 'i');
Console.WriteLine("#17 "+strCountChar);

//#18
BeginnerSeries beginnerSeries = new BeginnerSeries();
int milliSeconds = beginnerSeries.Past(1,30,46);
Console.WriteLine("#18 " + milliSeconds);


//#19
AlternatingCase alternatingCase = new AlternatingCase();
string strCase = alternatingCase.ToAlternatingCase("IbRaHiM ALzaMEl 1996");
Console.WriteLine("#19 " + strCase);

//#20
WillYouMakeIt willYouMakeIt = new WillYouMakeIt();
bool willYouMake = willYouMakeIt.ZeroFuel(100, 50, 2);
Console.WriteLine("#20 "+willYouMake);

//#21
StringUppercase stringUppercase = new StringUppercase();
bool isUpperCase = stringUppercase.IsUpperCase("HELLO");
Console.WriteLine("#21 "+isUpperCase);

//#22
BasicMathematicalOperations basicMathematicalOperations = new BasicMathematicalOperations();
double numberResult = basicMathematicalOperations.basicOp('*', 5, 5);
Console.WriteLine("#22 " + numberResult);

//#23
CountingSheep countingSheep = new CountingSheep();
int sheeps =  countingSheep.CountSheeps([true,  true,  true,  false,
     true,  true,  true,  true ,
     true,  false, true,  false,
     true,  false, false, true ,
     true,  true,  true,  true ,
     false, false, true,  true]);
Console.WriteLine("#23 " + sheeps);

//#24
SquareSum squareSum = new SquareSum();
int sumSquare = squareSum.squareSum([1, 2, 2]);
Console.WriteLine("#24 " + sumSquare);

//#25
CountOddNumbersBelow countOddNumbersBelow = new CountOddNumbersBelow();
ulong oddNumberCount = countOddNumbersBelow.OddCount(15023);
Console.WriteLine("#25 " + oddNumberCount);


//#26
CalculateAverage calculateAverage = new CalculateAverage();
double average = calculateAverage.FindAverage([1,5,10,8,6,4,3,2,3,4]);
Console.WriteLine("#26 " + average);

//#27
ReturnNegative returnNegative = new ReturnNegative();
int negative = returnNegative.MakeNegative(40);
Console.WriteLine("#27 " + negative);

//#28
SwapValues swapValues = new SwapValues([1,2]);   

//#29
DrinkAbout drinkAbout = new DrinkAbout();

//#30


//#31

