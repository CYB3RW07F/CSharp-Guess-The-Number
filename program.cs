using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Sharp number guesser!"); // Greet the user because we are 'nice'
      Random rnd = new Random(); // Create Random object
      int randomNumber = rnd.Next(1, 101); // Generates number from 1 to 100
      int tries = 0; // User starts with 0 tries (duh)
      int guess = 0; // 0 is a placeholder because i said so

      Console.WriteLine("Guess the secret Sharp number between 1-100");

      while (guess != randomNumber) // As long as the user guess is not the random number, do this
      {
        string input = Console.ReadLine(); // This is the user moment to shine, give the program your input

        if (!int.TryParse(input, out guess)) // Validate the user input because I want numbers and not something else ty
        {
          Console.WriteLine("Please enter a valid number!");
          continue;
        }

        tries++;

        if (guess < randomNumber) // If the user guess is lower than the random number, do this
        {
          Console.WriteLine(guess + " is too low!");
        }
        else if (guess > randomNumber) // If the user guess is higher than the random number, do this
        {
          Console.WriteLine(guess + " is too high!");
        }
      }
      Console.WriteLine("Congratulations! You guessed the number in " + tries + " tries."); // Congratulate the user when they finally guessed the number
    }
  }
}