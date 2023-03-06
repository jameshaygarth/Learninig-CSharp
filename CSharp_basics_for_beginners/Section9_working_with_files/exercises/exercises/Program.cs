using System;
using System.IO;
// See https://aka.ms/new-console-template for more information

static int GetNumberOfWordsInStrin(string str)
{
    return str.Split(" ").Length;
}
static string GetLongestWordInString(string str)
{
    var words = str.Split(" ");
    string longestWord = "";
    foreach (var word in words)
    {
        if (longestWord.Length < word.Length)
        {
            longestWord = word;
        }
    }
    return longestWord;
}


string txtFilePath = "C:\\temp\\tutorialRead.txt";
Console.WriteLine("Create a text file \"{0}\"", txtFilePath);
if (!File.Exists(txtFilePath))
{
    Console.WriteLine("File Doesnt Exist!");
    return;
}

var fileContents = File.ReadAllText(txtFilePath);

string longestWord = GetLongestWordInString(fileContents);
int numberOfWords = GetNumberOfWordsInStrin(fileContents);
Console.WriteLine("The longest word in the file is \"{0}\"", longestWord);
Console.WriteLine("Number Of Words {0}", numberOfWords);


