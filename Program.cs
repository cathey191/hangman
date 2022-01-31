using System;

class Hangman
{
    static void Main()
    {
        string mainWord = "funky";
        int numFailed = 0;


        while (true)
        {
            Console.WriteLine("Select a letter");
            char userInput = Console.ReadKey().KeyChar;
            char userLetter = Char.ToLower(userInput);

            Console.WriteLine();
            Console.WriteLine("You picked '" + userInput + "'");

            ValuateChar(userLetter, mainWord, ref numFailed);
        }
    }

    static void ValuateChar(char letter, string mainWord, ref int numFailed)
    {
        if (mainWord.Contains(letter))
        {
            Console.WriteLine("Does contain");
        }
        else
        {
            Console.WriteLine("Does not contain");
            numFailed++;
            Console.WriteLine("Failed - " + numFailed);
        }
    }
}