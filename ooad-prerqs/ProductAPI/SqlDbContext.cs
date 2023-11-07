using Microsoft.EntityFrameworkCore;
using ProductLib;

namespace ProductApi;

public class SqlDbContext : DbContext, IDbContext
{
  public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
  {
    Products = Set<Product>();
  }

  public DbSet<Product> Products { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlDbContext).Assembly);
  }
}