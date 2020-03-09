using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void CountWord_Instantiates_NewInstance()
    {
      CountWord newCountWord = new CountWord("test", "this is only a test");
      Assert.AreEqual(typeof(CountWord), newCountWord.GetType());
    }
    [TestMethod]
    public void CountWord_TakesInOneCharacter_A()
    {
      CountWord newCountWord = new CountWord("a", "");
      Assert.AreEqual("a", newCountWord.UserWord);
    }
    [TestMethod]
    public void CountRepeat_CountsWordsInSentence_1()
    {
      CountWord newCountWord = new CountWord("eggs", "eggs are one of my favorite breakfast food yay eggs");    
      Assert.AreEqual(2, newCountWord.CountRepeat());
    }
  }
}