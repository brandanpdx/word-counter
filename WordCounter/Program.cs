using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Start();
    }

    public static void Start()
    {
      Console.WriteLine("Please enter a sentence:");
      string usersentence = Console.ReadLine();
      Console.WriteLine("Please enter a word to check:");
      string userword = Console.ReadLine();
      CountWord newCountWord = new CountWord(userword,usersentence);

      int result = newCountWord.CountRepeat();

      Console.WriteLine("The word " + userword + " appears " + result + " time(s) in the sentence.");

    }
  }

}