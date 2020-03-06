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
    public void CaptureUserWord_CapturesTheUsersInput_TheirString()
    {
      // Arrange
      CountWord newCountWord = new CountWord();
      // Act
      string result = newCountWord.CaptureUserWord("string");
      // Assert
      Assert.AreEqual("0", result);
    }

  }
}