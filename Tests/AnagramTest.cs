using System.Collections.Generic;
using Xunit;

namespace Anagram
{
  public class AnagramTest
  {
    [Fact]
    public void Test1_ReturnsInput_Word()
    {
      string userInput = "bread";
      Anagram newAnagram = new Anagram(userInput);
      string match = newAnagram.SeeIfAnagram();

      Assert.Equal("bread", match);
    }
  }
}
