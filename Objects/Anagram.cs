using System.Collections.Generic;
using System;

namespace Anagram
{
  public class Anagram
  {
    private string _entry;

    public Anagram(string entry)
    {
      _entry = entry;
    }

    public string SeeIfAnagram()
    {
      return _entry;
    }

    public string Alphabetizer()
    {
        char[] newArray = _entry.ToCharArray();
        Array.Sort(newArray);
        string AlphaWord = string.Join("", newArray);
        return AlphaWord;
    }
  }
}
