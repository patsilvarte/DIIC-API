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
    public class IndexModel : PageModel
    {
        private readonly BeaconApi.models.BeaconContext _context;

        public IndexModel(BeaconApi.models.BeaconContext context)
        {
            _context = context;
        }

        public IList<BeaconItem> BeaconItem { get;set; }

        public async Task OnGetAsync()
        {
            BeaconItem = await _context.beaconItems.ToListAsync();
        }
    }
}
