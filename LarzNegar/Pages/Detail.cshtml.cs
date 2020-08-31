using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LarzNegar.Interface;
using LarzNegar.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LarzNegar.Pages
{
    public class DetailModel : PageModel
    {
        private readonly IEarthquackeData earthquackeData;

        [TempData]
        public string Message { get; set; }

        public Larz Larz { get; set; }

        public DetailModel(IEarthquackeData earthquackeData)
        {
            this.earthquackeData = earthquackeData;
        }
        public IActionResult OnGet(int LarzId)
        {
            Larz = earthquackeData.GetById(LarzId);
            if (Larz == null)
            {
                return RedirectToPage("Notfound");
            }
            return Page();

        }
    }
}