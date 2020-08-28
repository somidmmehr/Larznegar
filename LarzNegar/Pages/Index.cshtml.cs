using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LarzNegar.Interface;
using LarzNegar.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LarzNegar.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly InMemoryEarthquackeData earthquackeData;
        public IEnumerable<Larz> Earthquackes { get; set; }
        public string MagnituteStyle { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            this.earthquackeData = new InMemoryEarthquackeData();
        }

        public void OnGet()
        {
            this.Earthquackes = earthquackeData.GetAll().Take(5);
        }
    }
}
