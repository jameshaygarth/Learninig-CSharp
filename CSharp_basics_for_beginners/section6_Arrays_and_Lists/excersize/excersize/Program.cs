using System;
using System.Collections.Generic;
using System.Collections.Immutable;

// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Quiestion 1.");

List<string> LikerNames = new List<string>();
string displayString = "";

while (true)
{
    displayString = string.Empty;

    Console.WriteLine("Give me a liker or press enter to exit:");
    string name = Console.ReadLine();
    LikerNames.Add(name);

    if (name == "")
    {
        Console.Write("Exiting!!");
        break;
    }
    
    if (LikerNames.Count == 1)
    {
        displayString += LikerNames[0];
    }

    if (LikerNames.Count >= 2) {
        for (var i = 0; i < 2; i++)
        {
            string nameAppend = LikerNames[i];
            displayString += nameAppend;
            if (i == 0)
            {
                displayString += ", ";
            }
        }
    }

    if (LikerNames.Count == 3) {
        displayString += (" and 1 other");
    }
    else if (LikerNames.Count >3)
    {
        int otherLikers = LikerNames.Count - 2;
        displayString += (" and " + otherLikers + " others");
    }


    Console.WriteLine(displayString);
}

*/

/*
Console.WriteLine("2- Write a program and ask the user to enter their name. \n" +
    "Use an array to reverse the name and then store the result in a new string. \n" +
    "Display the reversed name on the console.\n\n");

Console.WriteLine("Type your Name and i will reverse it:");
string name = Console.ReadLine();
char[] nameChar = name.ToCharArray();
Array.Reverse(nameChar);
string nameReverse = new string(nameChar);
Console.WriteLine("Name in Reverse = {0}", nameReverse);
*/


/*
Console.WriteLine("3- Write a program and ask the user to enter 5 numbers. \n" +
    "If a number has been previously entered, display an error message and ask the user to re-try. \n" +
    "Once the user successfully enters 5 unique numbers, \n" +
    "sort them and display the result on the console.");
List<int> numbers = new List<int>();

while (true)
{
    numbers.Clear();
    Console.WriteLine("Enter 5 uneque numbers:");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Enter Number:");
        int number = int.Parse(Console.ReadLine());
        
        if (numbers.Contains(number))
        {
            Console.WriteLine("you have already entered this number try again!!");
            break;
        }
        else
        {
            numbers.Add(number);
        }

    }

    if (numbers.Count == 5)
    {
        numbers.Sort();
        Console.WriteLine("numbers sorted:");
        string displayString = "";
        foreach (int number in numbers) { 

            displayString += (number +",");
        }
        displayString= displayString.TrimEnd(',');
        Console.WriteLine(displayString);
        break;
    }
}

*/





/*
Console.WriteLine("4- Write a program and ask the user to continuously enter a number or type \"Quit\" to exit. \n" +
    "The list of numbers may include duplicates. Display the unique numbers that the user has entered.");

List<int> numbers = new List<int>();
Console.WriteLine("Enter all your numbers and i will return the uneque ones:");

while (true)
{
    Console.WriteLine("Enter a number or type Quit to exit:");
    string numberOrQuit = Console.ReadLine();   

    if (numberOrQuit == "Quit")
    {
        Console.WriteLine("Quitting!!");
        break;
    }

    int number = int.Parse(numberOrQuit);
    if (!numbers.Contains(number))
    {
        numbers.Add(int.Parse(numberOrQuit));
    }

}

string displayString = "";
numbers.Sort();
foreach (int number in numbers)
{
    displayString += (number+", "); 
}
displayString = displayString.TrimEnd(',');

Console.WriteLine(displayString);
*/

/*
Console.WriteLine("5- Write a program and ask the user to supply a list of comma separated numbers \n" +
    "(e.g 5, 1, 9, 2, 10). \n" +
    "If the list is empty or includes less than 5 numbers, \n" +
    "display \"Invalid List\" and ask the user to re-try; \n" +
    "otherwise, display the 3 smallest numbers in the list.");
while (true)
{

    Console.WriteLine("Enter a comma seperated list of 5 or more numbers:");
    string numbersRaw = Console.ReadLine();
    numbersRaw = numbersRaw.Replace(" ", "");

    var numbersSplit = numbersRaw.Split(',');
    List<int> numbers = new List<int>();
    foreach (var number in numbersSplit)
    {
        numbers.Add(int.Parse(number));
    }


    if (numbers.Count >= 5)
    {
        string displayString = "";
        numbers.Sort();
        numbers = numbers.Distinct().ToList();
        for (int i = 0; i < 3; i++)
        {
            displayString += (numbers[i] + ", ");
        }
        displayString = displayString.Replace(" ", "");
        displayString = displayString.TrimEnd(',');

        Console.WriteLine("Three smallest numbers = {0}", displayString);
        break;
    }
    Console.WriteLine("Try again not enough numbers!!");
}
*/