// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, this program will reverse a string entered by you!\nPlease enter your string to be reversed");
string sourceString, reversedString = "";
sourceString = Console.ReadLine();
Console.WriteLine("Your entered string is {0}", sourceString);
char[] reversedStringArray = new char[sourceString.Length];
for (int i = 0; i < sourceString.Length; i++)
{
    reversedStringArray[i] = sourceString[sourceString.Length-1-i];
}
reversedString = new string(reversedStringArray);
Console.WriteLine("Your reversed string is {0}",reversedString);
