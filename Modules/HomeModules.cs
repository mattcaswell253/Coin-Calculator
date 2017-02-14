using Nancy;
using System;
using System.Collections.Generic;
using CoinApp.Objects;

namespace CoinApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/output"] = _ => {
        Coins object1 = new Coins();
        string result = object1.Change(Request.Form["user-number"]);
        return View["output.cshtml", result];
      };
    }
  }
}
