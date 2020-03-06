using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void WordCounter_Instantiates_NewInstance()
    {
      // Arrange
      CountWord newCountWord = new CountWord("test", "this is only a test");
      // Assert
      Assert.AreEqual(typeof(CountWord), newCountWord.GetType());
    }
    [TestMethod]
    public void CountWord_TakesInWordAndSentence_True()
    {
    // Arrange
    CountWord newCountWord = new CountWord("test", "this is only a test");
    // Assert
    Assert.AreEqual("test", "this is only a test", newCountWord.CountWord());
    }


    [TestMethod]
    public void CountRepeats_CountsWordsInSentence_1()
    {
      // Arrange
      CountWord newCountWord = new CountWord("hi","hi");
      // Assert
      Assert.AreEqual(1, newCountWord.CountRepeats());

    }
  }
}