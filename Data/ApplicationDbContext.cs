using Microsoft.EntityFrameworkCore;
using Restaurante.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Plato> Platos { get; set; }
}
