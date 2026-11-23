/*
Lab 3.2 
2. Sum digits in string
Given a string, write a method which returns sum of all digits in that string. Assume that string contains only single digits.
Expected input and output
SumDigitsInString("1q2w3e") → 6 SumDigitsInString("L0r3m.1p5um") → 9
SumDigitsInString("") → 0
*/

string myString = "a1b2c3d5";
Console.WriteLine($"String {myString} Total = {DigitSum(myString)}");



int DigitSum(string StringToCheck)
{
    int total = 0;
    foreach (char c in StringToCheck)
    {
        if ( char.IsDigit(c) ) 
        {
            total += (int)char.GetNumericValue(c);
        }
    }
    return total;
}