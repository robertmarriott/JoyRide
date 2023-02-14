using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace JoyRide.Infrastructure.Persistence;

public class JoyRideDbContext : DbContext
{
    public JoyRideDbContext(DbContextOptions<JoyRideDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
