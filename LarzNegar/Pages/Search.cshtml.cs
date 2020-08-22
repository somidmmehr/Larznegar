using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LarzNegar.Pages
{
    public class SearchModel : PageModel
    {
        public string city { get; private set; }
        public void OnGet(string city)
        {
            this.city = city;
        }
    }
}
