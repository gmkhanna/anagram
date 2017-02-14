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

    }
  }
}
