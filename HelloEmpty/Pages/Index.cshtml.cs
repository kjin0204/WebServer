using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloEmpty.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public HelloMessage HelloMsg { get; set; }

        public string Notis { get; set; }
        public void OnGet()
        {
            this.HelloMsg = new HelloMessage()
            {
                Message = "Hello Razor Pages"
            };

            //this.Notis = 
        }


        public void OnPost()
        {
            this.Notis = "message Change";
        }
    }
}
