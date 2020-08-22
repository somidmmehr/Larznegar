using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LarzNegar.Interface;
using LarzNegar.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace LarzNegar.Pages
{
    public class HelpModel : PageModel
    {
        private readonly IConfiguration config;
        private InMemoryEarthquackeData earthquackeData;
        public string Message { get; private set; }
        public IEnumerable<Larz> Earthquackes { get; set; }

        public HelpModel(IConfiguration config)
        {
            this.config = config;
            this.earthquackeData = new InMemoryEarthquackeData();
        }

        public void OnGet()
        {
            Message = config["Message-Test"];
            Earthquackes = earthquackeData.GetAll();
        }
    }
}
