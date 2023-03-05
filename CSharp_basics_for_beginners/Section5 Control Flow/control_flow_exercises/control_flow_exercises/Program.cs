// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
/*
Console.WriteLine("1 - Write a program and ask the user to enter a number. " +
    "The number should be between 1 to 10. If the user enters a valid number, " +
    "display 'Valid' on the console. Otherwise, display 'Invalid'. " +
    "(This logic is used a lot in applications where values entered " +
    "into input boxes need to be validated.\n\n");

Console.WriteLine("Enter a number between 1 and 10:");
string user_number_raw = Console.ReadLine();
int user_number;
try
{
    user_number = Convert.ToInt32(user_number_raw);
}
catch
{
    Console.WriteLine("Not a number!!");
    user_number = 0;
}

if ((user_number >= 1) && (user_number <= 10))
{
    Console.WriteLine("Valid");
}
else
{
    Console.WriteLine("Invalid");
}



*/
/*
Console.WriteLine("2 - Write a program which takes two numbers from the console " +
    "and displays the maximum of the two.\n\n");

Console.WriteLine("First Number:");
string first_number_raw = Console.ReadLine();

Console.WriteLine("Second Number:");
string second_number_raw = Console.ReadLine();

int first_number = Convert.ToInt32(first_number_raw);
int second_number = Convert.ToInt32(second_number_raw);
if (first_number > second_number)
{
    Console.WriteLine("Frist Number is the biggest");
}
else if (second_number > first_number)
{
    Console.WriteLine("Second Number is the biggest");
}
else if (first_number == second_number)
{
    Console.WriteLine("Both your numbers were tha same!!");
}
else
{
    Console.WriteLine("well thie numbers you have entered are'nt numbers");
}
*/
/*
Console.WriteLine("3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.");


Console.WriteLine("Width:");
string width_raw = Console.ReadLine();

Console.WriteLine("Height:");
string height_raw = Console.ReadLine();

int width = Convert.ToInt32(width_raw);
int height = Convert.ToInt32(height_raw);
if (width > height)
{
    Console.WriteLine("landscape");
}
else if (height > width)
{
    Console.WriteLine("portrait");
}
else if (width == height)
{
    Console.WriteLine("square");
}
else
{
    Console.WriteLine("well thie numbers you have entered are'nt numbers");
}
*/

Console.WriteLine("4- Your job is to write a program for a speed camera. " +
    "For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. " +
    "Write a program that asks the user to enter the speed limit. " +
    "Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, " +
    "program should display Ok on the console. If the value is above the speed limit, " +
    "the program should calculate the number of demerit points. For every 5km/hr above the speed limit, " +
    "1 demerit points should be incurred and displayed on the console." +
    " If the number of demerit points is above 12, " +
    "the program should display License Suspended.");


Console.WriteLine("Enter the speed limit:");
int speedlimit = Convert.ToInt32(Console.ReadLine());

const int MaxPoints = 12;
int driverPoints = 0;

while(driverPoints < MaxPoints){
    Console.WriteLine("enter Current Speed:");
    int currentSpeed = Convert.ToInt32(Console.ReadLine());
    if (currentSpeed > speedlimit)
    {
        int demerit_count  = (currentSpeed - speedlimit) / 5;
        driverPoints += demerit_count;
        Console.WriteLine("demerit_count = {0}", demerit_count);
        Console.WriteLine("driverPoints = {0}", driverPoints);
    }
    else {
        Console.WriteLine("you are within the speed limit");
    }
}
Console.WriteLine("License Suspended.");