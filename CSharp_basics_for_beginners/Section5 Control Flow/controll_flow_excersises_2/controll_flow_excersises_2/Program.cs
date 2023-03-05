using System;

/*
Console.WriteLine("1- Write a program to count how many numbers between 1 and \n" +
    "100 are divisible by 3 with no remainder. Display the count on the \n" +
    "console.");

int numberOfNumbersDevisableBy3 = 0;
for  (int i = 1; i <= 100; i++)
{
    //Console.WriteLine("{0}  {1}",i,i % 3);
    if (i % 3 == 0)
    {
        numberOfNumbersDevisableBy3++;
    }
}

Console.WriteLine(numberOfNumbersDevisableBy3);
*/





/*
Console.WriteLine("2- Write a program and continuously ask the user to enter a\n " +
    "number or \"ok\" to exit. Calculate the sum of all the previously \n" +
    "entered numbers and display it on the console.");

int sum = 0;
while (true)
{
    Console.WriteLine("Enter a number to contunue or ok to exit:");
    string input = Console.ReadLine();

    if(input == "ok")
    {
        Console.WriteLine("You have exited the Programm!!");
        break;
    }

    if(input != null)
    {
        int inputNumber = int.Parse(input);
        sum += inputNumber;
        Console.WriteLine("Sum of numbers entered = {0}", sum);

    }
    else {
        Console.WriteLine("You Have not entered anything!!");
    }
    
}
*/

/*
Console.WriteLine("3- Write a program and ask the user to enter a number. Compute \n" +
    "the factorial of the number and print it on the console. For \n" +
    "example, if the user enters 5, \n" +
    "the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.");


Console.WriteLine("Enter the number you Want the factorial of:");
int number = int.Parse(Console.ReadLine());
int factorial = number;
for (int i = number-1; i >= 1; i--)
{
    Console.WriteLine("{0} {1}", i, factorial);
    factorial *= i;
}
Console.WriteLine("{0}! = {1}",number,factorial);
*/




/*
Console.WriteLine("4- Write a program that picks a random number between 1 and 10. \n" +
    "Give the user 4 chances to guess the number. If the user guesses the number, \n" +
    "display “You won\"; otherwise, display “You lost\". \n" +
    "(To make sure the program is behaving correctly, \n" +
    "you can display the secret number on the console first.)");

Random rnd = new Random();
int randomNumber = rnd.Next(1,10);
int numberOfChances = 4;
for (int i = 1; i <= numberOfChances; i++)
{
    Console.WriteLine("Enter a Number Between 1 and 10:);
    int guess = int.Parse(Console.ReadLine());


    if (guess == randomNumber)
    {
        Console.WriteLine("You won");
        break;
    }

    if (i == numberOfChances)
    {
        Console.WriteLine("You Lost");
        Console.WriteLine("The CorrectNumber Was = {0}",randomNumber);
    }
    else
    {
        Console.WriteLine("Try Again");
    }

}
*/





/*
Console.WriteLine("5- Write a program and ask the user to enter a series of numbers separated by comma. \n" +
    "Find the maximum of the numbers and display it on the console. \n" +
    "For example, if the user enters “5, 3, 8, 1, 4\", the program should display 8.");

Console.WriteLine("Enter a series of comma seperated numbers:");
string inputNumbersRaw = Console.ReadLine();
string[] inputNumbers = inputNumbersRaw.Replace(" ","").Split(",");

int maxNumber = 0;
foreach (string inputNumber in inputNumbers)
{
    int number = int.Parse(inputNumber);
    if (number > maxNumber)
    {
        maxNumber = number;
    }
}
Console.WriteLine(maxNumber.ToString());
*/