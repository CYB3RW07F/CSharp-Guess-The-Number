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
      Console.WriteLine("Guess the secret Sharp number between 1-100"); // I am not going to explain every line of text
      int guess = Convert.ToInt32(Console.ReadLine()); // Convert users string input to int
      Console.WriteLine("The number you put in was: " + guess);
      Console.WriteLine("The actual number was: " + randomNumber);
      // while (guess != randomNumber)
      // {

      // }
    }
  }
}