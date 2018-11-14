using Microsoft.EntityFrameworkCore;

namespace TodoApi.models
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