using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Sharp number guesser!"); // Greet the user because we are 'nice'
      Random rnd = new Random(); // Create Random object
      int randomNumber = rnd.Next(1, 101); // Generates number from 1 to 100 (inclusive)
      int tries = 0; // User starts with 0 tries (duh)
      Console.WriteLine("Guess the secret Sharp number between 1-100"); // I am not going to explain every line of text
      int guess = Convert.ToInt32(Console.ReadLine()); // Convert users string input to int
      while (guess != randomNumber) // As long as the user guess is not the random number, do this
      {
        if (guess < randomNumber) // If the user guess is lower than the random number, do this
        {
          Console.WriteLine(guess + " is too low!");
          break;
        }
        else if (guess > randomNumber) // If the user guess is higher than the random number, do this
        {
          Console.WriteLine(guess + "is too high!");
          break;
        }
      }
    }
  }
}