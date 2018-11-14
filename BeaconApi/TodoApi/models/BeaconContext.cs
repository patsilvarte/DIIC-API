using Microsoft.EntityFrameworkCore;

namespace BeaconApi.models
{
    public class BeaconContext : DbContext
    {
        public BeaconContext(DbContextOptions<BeaconContext> options)
            : base(options)
        {
        }

        public DbSet<BeaconItem> beaconItems { get; set; }
    }
}