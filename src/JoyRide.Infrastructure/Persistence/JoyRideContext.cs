using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace JoyRide.Infrastructure.Persistence;

public class JoyRideContext : DbContext
{
    public JoyRideContext(DbContextOptions<JoyRideContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
