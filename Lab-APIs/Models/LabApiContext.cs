using Microsoft.EntityFrameworkCore;

namespace Lab_APIs.Models
{
    public class LabApiContext: DbContext
    {
        public LabApiContext()
        {

        }

        public LabApiContext(DbContextOptions<LabApiContext> options): base(options)
        {

        }

        public virtual DbSet<Route> Routes { get; set; } = null!;
        public virtual DbSet<ScheduledStop> ScheduledStops { get; set; } = null!;
        public virtual DbSet<Stop> Stops { get; set; } = null!;
    }
}
