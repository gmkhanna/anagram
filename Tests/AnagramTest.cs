using System.Collections.Generic;
using Xunit;
using System;

namespace Anagram
{
  public class AnagramTest
  {
    [Fact]
    public void Test5_CountMatchWords_Counter()
    {
      string userInput2 = "bread";
      string userInput3 = "I have a beard";
      Anagram newAnagram = new Anagram(userInput2, userInput3);
      int match = newAnagram.Alphabetizer();

      Assert.Equal(1, match);
    }

    // [Fact]
    // public void Test2_Alphabetizer_True()
    // {
    //   string userInput2 = "bread";
    //   Anagram newAnagram = new Anagram(userInput2);
    //   string match = newAnagram.Alphabetizer();
    //
    //   Assert.Equal("abder", match);
    // }

    // [Fact]
    // public void Test3_CheckIfAnagram_True()
    // {
    //   string userInput3 = "beard";
    //   string userInput4 = "bread";
    //   Anagram newAnagram = new Anagram(userInput3, userInput4);
    //   string match = newAnagram.Alphabetizer();
    //
    //   Assert.Equal(userInput4, match);
    // }
    //
    // [Fact]
    // public void Test4_CheckIfAnagram_True()
    // {
    //   string userInput3 = "beard";
    //   string userInput4 = "bread";
    //   Anagram newAnagram = new Anagram(userInput3, userInput4);
    //   string match = newAnagram.Alphabetizer();
    //
    //   Assert.Equal(userInput4, match);
    // }
  }
}
