using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeaconApi.models;

namespace BeaconApi.Pages.Beacons
{
    public class CreateModel : PageModel
    {
        private readonly BeaconApi.models.BeaconContext _context;

        public CreateModel(BeaconApi.models.BeaconContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BeaconItem BeaconItem { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.beaconItems.Add(BeaconItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}