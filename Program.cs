using System;

class Hangman
{
    static void Main()
    {
        string mainWord = "Funky";
        
        Console.WriteLine("Select a letter");
        char userInput = Console.ReadKey().KeyChar;
        
        Console.WriteLine();
        Console.WriteLine("You picked '" + userInput + "'");
    }
}