/*
Week 2 Lab 2
2. Write a C# Sharp program that takes userid and password as input (type string). 
After 3 wrong attempts, user will be rejected.
*/

string realUserID = "Admin";
string realPassword = "password1234";

int attempts = 0;

do
{
    Console.Write("Enter username: ");
    string userInputUsername = Console.ReadLine();
    Console.Write("Enter password: ");
    string userInputPassword = Console.ReadLine();

    if (userInputUsername == realUserID && userInputPassword == realPassword)
    {
        Console.WriteLine("Congratulations! User accepted.");
        break;
    }
    else
    {
        Console.WriteLine("Error! Try again.");
        attempts++;
    }
} while (attempts < 3); 

if ( attempts >= 3)
{
    Console.WriteLine("User rejected!");
}
