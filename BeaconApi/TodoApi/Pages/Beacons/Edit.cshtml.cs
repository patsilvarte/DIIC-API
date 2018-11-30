using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeaconApi.models;

namespace BeaconApi.Pages.Beacons
{
    public class EditModel : PageModel
    {
        private readonly BeaconApi.models.BeaconContext _context;

        public EditModel(BeaconApi.models.BeaconContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BeaconItem BeaconItem { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BeaconItem = await _context.beaconItems.FirstOrDefaultAsync(m => m.BeaconId == id);

            if (BeaconItem == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BeaconItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeaconItemExists(BeaconItem.BeaconId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BeaconItemExists(string id)
        {
            return _context.beaconItems.Any(e => e.BeaconId == id);
        }
    }
}
