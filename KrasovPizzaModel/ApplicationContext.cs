using Microsoft.EntityFrameworkCore;

namespace KrasovPizzaModel;

internal class ApplicationContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Krasov-Pizza;Username=postgres;Password=Rammstein1994");
    }
}
