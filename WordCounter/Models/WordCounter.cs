using System;

namespace WordCounter.Models
{
  class WordCounter
  {
    public string UserWord { get; set; }
    public string UserSentence { get; set; }

    public Counter(string userinputword, string userinputsentence)
    {
      userinputword = UserWord;
      userinputsentence = UserSentence;
    }
    
    public static void TempMethod()
    {

    }
  }

}