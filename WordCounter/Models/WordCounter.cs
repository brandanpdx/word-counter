using System;

namespace WordCounter.Models
{
  public class CountWord
  {
    public string UserWord { get; set; }
    public string UserSentence { get; set; }

    public CountWord(string userinputword, string userinputsentence)
    {
      userinputword = UserWord;
      userinputsentence = UserSentence;
    }

    public int CountRepeats()
    {
      string userword = this.UserWord;
      string[] wordarray = UserSentence.Split(' ');
      int counter = 0;

      foreach (string word in wordarray)
      {
        if (userword == word)
        {
          counter++;
        }
      }
      return counter;
    }
  }

}