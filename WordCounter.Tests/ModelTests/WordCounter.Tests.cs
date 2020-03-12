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
    public void CountWord_TakesInOneCharacterWord_A()
    {
      CountWord newCountWord = new CountWord("a", "");
      Assert.AreEqual("a", newCountWord.UserWord);
    }
    [TestMethod]
    public void CountWord_TakesInMultiCharacterWord_To()
    {
      CountWord newCountWord = new CountWord("to", "");
      Assert.AreEqual("to", newCountWord.UserWord);
    }
    [TestMethod]
    public void CountWord_TakesInSentence_HelloThere()
    {
      CountWord newCountWord = new CountWord("", "hello there");
      Assert.AreEqual("hello there", newCountWord.UserSentence);
    }
    [TestMethod]
    public void CountRepeat_CountsWordsInSentence_1()
    {
      CountWord newCountWord = new CountWord("eggs", "eggs are one of my favorite breakfast food yay eggs");    
      Assert.AreEqual(2, newCountWord.CountRepeat());
    }
    [TestMethod]
    public void CountRepeat_CountsOnlyFullWord_2()
    {
      CountWord newCountWord = new CountWord("cat", "cat cathedral cat");    
      Assert.AreEqual(1, newCountWord.CountRepeat());
    }
  }
}