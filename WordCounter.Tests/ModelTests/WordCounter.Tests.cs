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
      CountWord newCountWord = new CountWord();
      // Act
      newCountWord.Counter("test", "this is only a test");
      // Assert
      Assert.AreEqual(typeof(CountWord), newCountWord.GetType());
    }
    [TestMethod]
    public void CaptureUserWord_CapturesTheUsersWord_TheirWord()
    {
      // Arrange
      CountWord newCountWord = new CountWord();
      // Act
      string result = newCountWord.CaptureUserWord("word");
      // Assert
      Assert.AreEqual("word", result);
    }
    [TestMethod]
    public void CaptureUserSentence_CapturesTheSentence_TheirSentence()
    {
      // Arrange
      CountWord newCountWord = new CountWord();
      // Act
      string result = newCountWord.CaptureUserSentence("this is sparta");
      // Assert
      Assert.AreEqual("this is jef", result);
    }
  }
}