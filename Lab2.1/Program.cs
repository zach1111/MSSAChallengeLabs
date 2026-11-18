/*
Week 2 Lab 1
1. Write a C# Sharp program to read temperature in Fahrenheit and display a suitable message according to temperature state below :
Temp 0< 10 then Freezing weather
Temp 11-20 then Very Cold weather
Temp 21-35 then Cold weather
Temp 36-50 then Normal in Weather
Temp 51-65 then Its Hot
Temp 66-80 then Its Very Hot
Test Data :
67
Expected Output :
Its very hot.
*/


Console.Write("Input temperature in Farenheit: ");
int temperature = int.Parse(Console.ReadLine());


switch (temperature)
{
    case >= 0 and <= 10:
        Console.WriteLine("Freezing weather!");
        break;
    case >= 11 and <= 20:
        Console.WriteLine("Very Cold!");
        break;
    case >= 21 and <= 35:
        Console.WriteLine("Cold!");
        break;
    case >= 36 and <= 50:
        Console.WriteLine("Normal!");
        break;
    case >= 51 and <= 65:
        Console.WriteLine("Hot!");
        break;
    case >= 66 and <= 80:
        Console.WriteLine("Very Hot!");
        break;
    default:
        Console.WriteLine("Error, check input");
        break;
}