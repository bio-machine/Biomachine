using Biomachine.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Biomachine.DAL.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    #region DbSet Properties
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    #endregion
}
