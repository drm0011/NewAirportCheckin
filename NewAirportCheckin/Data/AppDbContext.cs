using Microsoft.EntityFrameworkCore;
using NewAirportCheckin.Models;

namespace NewAirportCheckin.Data
{
    public class AppDbContext : DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Passenger> Passengers { get; set; }
        }
    }

