using Microsoft.EntityFrameworkCore;

namespace Test2.Context;

public class RepairShopDbContext : DbContext
{
    public RepairShopDbContext()
    {
    }

    public RepairShopDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=db-mssql16.pjwstk.edu.pl; Initial Catalog=s18614;Integrated Security=True");
    }

    public DbSet<Models.Car> Cars { get; set; }
    public DbSet<Models.Mechanic> Mechanics { get; set; }
    public DbSet<Models.Inspection> Inspections { get; set; }
    public DbSet<Models.ServiceTypeDict> ServiceTypes { get; set; }
    public DbSet<Models.ServiceTypeDict_Inspection> ServiceTypeDict_Inspections { get; set; }
}
