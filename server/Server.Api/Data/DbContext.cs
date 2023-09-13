
using Microsoft.EntityFrameworkCore;
using Server.Api.Models;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Locations{ get; set; } = default!;

        public DbSet<ChargingStation> ChargingStations { get; set; } = default!;
    }
