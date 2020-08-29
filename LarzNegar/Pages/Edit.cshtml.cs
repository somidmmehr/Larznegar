using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
    public class EditModel : PageModel
    {
        private readonly IEarthquackeData earthquackeData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Larz Larz { get; set; }
        public IEnumerable<SelectListItem> FaultType { get; set; }

        public EditModel(IEarthquackeData earthquackeData, IHtmlHelper htmlHelper)
        {
            this.FaultType = htmlHelper.GetEnumSelectList<FaultType>();
            this.earthquackeData = earthquackeData;
            this.htmlHelper = htmlHelper;
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

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Larz = earthquackeData.Update(Larz);
                earthquackeData.Commit();
                return RedirectToPage("Detail", new { LarzId = Larz.Id });
            }
            return Page();
        }

    }
}