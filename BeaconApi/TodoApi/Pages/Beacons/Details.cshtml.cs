using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeaconApi.models;

namespace BeaconApi.Pages.Beacons
{
    public class DetailsModel : PageModel
    {
        private readonly BeaconApi.models.BeaconContext _context;

        public DetailsModel(BeaconApi.models.BeaconContext context)
        {
            _context = context;
        }

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
    }
}
