using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
      //Adding a private read only property that maps to the config file
      private readonly IConfiguration config;

      //Reference to this property by @ModelmMessage in the view
      public string Message { get; set; }
      public string MessageFromConfig { get; set; }

    //Adding constructor to get data from configutation file
    public ListModel(IConfiguration config)
      {
        this.config = config;
      }

      //Responds to a GET HTTP request
      public void OnGet()
      {
        Message = "Hello world";
        MessageFromConfig = config["MessageFromConfig"];
      }
    }
}
