using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LarzNegar.Interface;
using LarzNegar.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LarzNegar.Pages
{
    public class SearchModel : PageModel
    {
        private readonly InMemoryEarthquackeData earthquackeData;
        public IEnumerable<Larz> Earthquakes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        public SearchModel()
        {
            this.earthquackeData = new InMemoryEarthquackeData();
        }

        public void OnGet()
        {
            this.Earthquakes = earthquackeData.GetAll(Search);
        }
    }
}
