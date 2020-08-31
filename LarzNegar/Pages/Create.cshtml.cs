using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LarzNegar.Interface;
using LarzNegar.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace LarzNegar.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IEarthquackeData earthquackeData;

        [BindProperty]
        public Larz Larz { get; set; }
        public IEnumerable<SelectListItem> FaultType { get; set; }
        public CreateModel(IEarthquackeData earthquackeData ,IHtmlHelper htmlHelper)
        {
            this.FaultType = htmlHelper.GetEnumSelectList<FaultType>();
            this.earthquackeData = earthquackeData;
        }
        public void OnGet()
        {
            Larz = new Larz();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Larz = earthquackeData.Create(Larz);
                earthquackeData.Commit();
                return RedirectToPage("Detail", new { LarzId = Larz.Id });
            }
            return Page();
        }
    }
}