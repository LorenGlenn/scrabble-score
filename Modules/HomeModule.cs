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
      Post["/submit"] = _ =>
      {
        Game newGame = new Game(Request.Form["input"]);
        return View["index.cshtml", newGame.GetStringVal()];
      };
    }
  }
}
