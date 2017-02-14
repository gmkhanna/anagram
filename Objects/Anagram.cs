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

    public string Alphabetizer()
    {
        string none = "none";
        char[] entryArray = _entry.ToCharArray();
        Array.Sort(entryArray);
        string alphaEntry = string.Join("", entryArray);

        char[] compareArray = _compare.ToCharArray();
        Array.Sort(compareArray);
        string alphaCompare = string.Join("", compareArray);

        if (alphaEntry == alphaCompare)
        {
          return _compare;
        }
        else
        {
          return none;
        }
    }
  }
}
