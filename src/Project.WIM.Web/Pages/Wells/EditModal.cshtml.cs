using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.WIM.Wells;

namespace Project.WIM.Web.Pages.Wells
{
    public class EditModalModel : WIMPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateWellDto Well { get; set; }

        private readonly IWellAppService _wellAppService;

        public EditModalModel(IWellAppService wellAppService)
        {
            _wellAppService = wellAppService;
        }

        public async Task OnGetAsync()
        {
            var wellDto = await _wellAppService.GetAsync(Id);
            Well = ObjectMapper.Map<WellDto, CreateUpdateWellDto>(wellDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _wellAppService.UpdateAsync(Id, Well);
            return NoContent();
        }
    }
}
