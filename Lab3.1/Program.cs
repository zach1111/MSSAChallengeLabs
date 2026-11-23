/*
Lab 3.1
1. Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). Assume that string may consist only of lower-case letters.

Expected input and output

IsPalindrome("eye") → true

IsPalindrome("home") → false
*/


Console.Write("give string: ");
string myString = Console.ReadLine();
Console.WriteLine($"String \"{myString}\" palindrome? {IsPalindrome(myString)} ");


bool IsPalindrome(string StringToCheck)
{
    
    for ( int i = 0 ; i < (StringToCheck.Length/2) ; i++ ) //odd length string don't need to check middle value
    {
        if ( StringToCheck[i] != StringToCheck[StringToCheck.Length-1-i] )
        {
            return false;
        }
    }
    return true;
}