using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.WIM.Wells;

namespace Project.WIM.Web.Pages.Wells
{
    public class CreateModalModel : WIMPageModel
    {
        [BindProperty]
        public CreateUpdateWellDto Well { get; set; }

        private readonly IWellAppService _wellAppService;

        public CreateModalModel(IWellAppService wellAppService)
        {
            _wellAppService = wellAppService;
        }
        public void OnGet()
        {
            Well = new CreateUpdateWellDto();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _wellAppService.CreateAsync(Well);
            return NoContent();
        }
    }
}
