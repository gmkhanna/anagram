using System.Collections.Generic;
using System;

namespace Anagram
{
  public class Anagram
  {
    private string _entry;
    private string _compare;

    public Anagram(string entry, string compare)
    {
      _entry = entry;
      _compare = compare;
    }

    public int Alphabetizer()
    {
      int counter = 0;
      char[] entryArray = _entry.ToCharArray();
      Array.Sort(entryArray);
      string alphaEntry = string.Join("", entryArray);

      string[] words = _compare.Split(' ');
      foreach(string word in words)
      {
        char[] compareArray = word.ToCharArray();
        Array.Sort(compareArray);
        string alphaCompare = string.Join("", compareArray);
        if (alphaEntry == alphaCompare)
        {
          counter++;
        }
      }
      return counter;
    }
  }
}
