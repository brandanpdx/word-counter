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
      // Arrange
      CountWord newCountWord = new CountWord("test", "this is only a test");
      // Assert
      Assert.AreEqual(typeof(CountWord), newCountWord.GetType());
    }

    [TestMethod]
    public void CountRepeat_CountsWordsInSentence_1()
    {
      // Arrange
      CountWord newCountWord = new CountWord("eggs", "eggs are one of my favorite breakfast food yay eggs");    
      // Assert
      Assert.AreEqual(2, newCountWord.CountRepeat());
    }
  }
}