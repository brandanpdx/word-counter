using System;

namespace WordCounter.Models
{
  public class CountWord
  {
    public string UserWord { get; set; }
    public string UserSentence { get; set; }

    public CountWord(string userinputword, string userinputsentence)
    {
      UserWord = userinputword;
      UserSentence = userinputsentence;
    }

    public int CountRepeat()
    {
      string userword = this.UserWord;
      string userssentences = this.UserSentence;
      string[] wordarray = userssentences.Split(" ");
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