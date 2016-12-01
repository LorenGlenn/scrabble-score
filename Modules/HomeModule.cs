using Nancy;
using Scrabble.Objects;
using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=> View["index.cshtml"];
    }
  }
}
