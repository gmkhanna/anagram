using System;
using Anagram;
using System.Collections.Generic;
using Nancy;

namespace Anagram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/display"] = _ => {
        string userWord = Request.Form["indiv-word"];
        string userText = Request.Form["text-set"];
        Anagram newAnagram = new Anagram(userWord, userText);
        string result = newAnagram.Alphabetizer();
        return View["display.cshtml", result];
      };
    }
  }
}
