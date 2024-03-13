// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

string name;
string input;
int score = 0;
int coin;
int answer;
Random rnd = new Random();

Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("Would you like to do the coin flip challenge?");
input = Console.ReadLine();

    if (input == "Yes")
{
    for ( int i = 0; i < 5; i++)
    {
        rnd = new Random();
        coin = rnd.Next(1,10)%2;
        Console.WriteLine("Heads or Tails?");
        input = Console.ReadLine();
        answer = 2;
        if (input == "Heads")
        {
            answer = 0;
        } if (input == "Tails")
        {
            answer = 1;
        }
        if (answer == coin)
        {
            score++;
            Console.WriteLine("Correct! Score is now " + score);
        } else
        {
            Console.WriteLine("Wrong! Score is " + score);
        }
    }
    Console.WriteLine(name + ", your score ended with " + score);
} else if (input == "No")
{
    Console.WriteLine("You are a coward " + name);
}
