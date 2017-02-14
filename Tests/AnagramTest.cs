using System.Collections.Generic;
using Xunit;
using System;

namespace Anagram
{
  public class AnagramTest
  {
    [Fact]
    public void Test1_ReturnsInput_Word()
    {
      string userInput1 = "bread";
      Anagram newAnagram = new Anagram(userInput1);
      string match = newAnagram.SeeIfAnagram();

      Assert.Equal("bread", match);
    }

    [Fact]
    public void Test2_Alphabetizer_True()
    {
      string userInput2 = "bread";
      Anagram newAnagram = new Anagram(userInput2);
      string match = newAnagram.Alphabetizer();

      Assert.Equal("abder", match);
      Console.WriteLine(match);
    }
  }
}
