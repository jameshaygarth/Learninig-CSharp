using System;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("1- Write a program and ask the user to enter \n" +
    "a few numbers separated by a hyphen. \n" +
    "Work out if the numbers are consecutive. For example, \n" +
    "if the input is \"5-6-7-8-9\" or \"20-19-18-17-16\", \n" +
    "display a message: \"Consecutive\"; \n" +
    "otherwise, display \"Not Consecutive\".\n\n");


Console.WriteLine("enter a list of numbers seperated by a hyphen\n" +
    "and i will tell you if they are consecutive:");
string numbersHyphen = Console.ReadLine();
var numbersHyphenSplit = numbersHyphen.Split("-");


int lastNumber=0;
for (int i = 0; i < numbersHyphenSplit.Length; i++)
{
    var number = Convert.ToInt32(numbersHyphenSplit[i].Trim());

    if (i == 0) lastNumber = number;
    else if (number == (lastNumber + 1)) lastNumber = number;
    else if (number == (lastNumber - 1)) lastNumber = number;
    else {
        Console.WriteLine("Not Consecutive");
        break;
     };

    if (i==numbersHyphenSplit.Length - 1)
    {
        Console.WriteLine("Consecutive");
    }

}


*/
/*
Console.WriteLine("2- Write a program and ask the user to enter a few numbers \n" +
    "separated by a hyphen. If the user simply presses Enter, without \n" +
    "supplying an input, exit immediately; otherwise, check to see if \n" +
    "there are duplicates. If so, display \"Duplicate\" on the console.");



Console.WriteLine("enter a list of numbers seperated by a hyphen\n" +
    "and i will tell you if there are diplicates:");
string numbersHyphen = Console.ReadLine();
if (string.IsNullOrEmpty(numbersHyphen))
{
    Console.WriteLine("nothing entered quitting");
    return;
}
var numbersHyphenSplit = numbersHyphen.Split("-");


List<int> numbers = new List<int>();

for (int i = 0; i < numbersHyphenSplit.Length; i++)
{
    var number = Convert.ToInt32(numbersHyphenSplit[i].Trim());
    numbers.Add(number);


}
int numbersWithDuplicatesLength = 0;
int numbersWithoutDuplicatesLength = 0;

numbersWithDuplicatesLength = numbers.Count;
numbers = numbers.Distinct().ToList();
numbersWithoutDuplicatesLength=numbers.Count;
if (numbersWithoutDuplicatesLength == numbersWithDuplicatesLength)
{
    Console.WriteLine("No Duplicates");
}
else
{
    Console.WriteLine("Duplicates");
}
*/


/*
Console.WriteLine("3- Write a program and ask the user to enter a time value \n" +
    "in the 24-hour time format (e.g. 19:00). A valid time should be between \n" +
    "00:00 and 23:59. If the time is valid, display \"Ok\"; otherwise, display\n" +
    " \"Invalid Time\". \n" +
    "If the user doesn't provide any values, consider it as invalid time.");


 
Console.WriteLine("Type time in 24hour format hour:min :");
string enteredTimeRaw = Console.ReadLine();

try
{
    var enteredTime = DateTime.Parse(enteredTimeRaw);
    Console.WriteLine("Ok");
}
catch
{
    Console.WriteLine("Invalid Time");
}
*/
/*
Console.WriteLine("4- Write a program and ask the user to enter a few words separated by a space. \n" +
    "Use the words to create a variable name with PascalCase. For example, if the user types: \n" +
    "\"number of students\", display \"NumberOfStudents\". Make sure that the program is not dependent \n" +
    "on the input. So, if the user types \"NUMBER OF STUDENTS\", the program should still display \"NumberOfStudents\".");

Console.WriteLine("Enter works for variable with spaces: ");

string wordsForVariable = Console.ReadLine();
var wordsForVariableSplit = wordsForVariable.Split(" ");

var variableWord = "";
for (int i = 0; i < wordsForVariableSplit.Length; i++)
{
    wordsForVariableSplit[i] = wordsForVariableSplit[i].ToLower();
    variableWord += char.ToUpper(wordsForVariableSplit[i][0]).ToString()+ wordsForVariableSplit[i].Substring(1);
}
Console.WriteLine(variableWord);
*/

/*
Console.WriteLine("5- Write a program and ask the user to enter an English word. \n" +
    "Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters \n" +
    "\"inadequate\", the program should display 6 on the console.");

Console.WriteLine("Enter a word and i will tell you howmany vowles are in it: ");
int vowlesCount = 0;
char[] vowles = { 'a', 'e', 'i', 'o', 'u' };
string word = Console.ReadLine();
word = word.ToLower();
foreach(var letter in word.ToCharArray())
{
    if (vowles.Contains(letter))
    {
        vowlesCount++;
    }
}
Console.WriteLine(vowlesCount);
*/