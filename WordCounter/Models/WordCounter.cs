using System;

namespace WordCounter.Models
{
  public class CountWord
  {
    public string UserWord { get; set; }
    public string UserSentence { get; set; }

    public void Counter(string userinputword, string userinputsentence)
    {
      userinputword = UserWord;
      userinputsentence = UserSentence;
    }
    
    public static void TempMethod()
    {

    }
  }

}