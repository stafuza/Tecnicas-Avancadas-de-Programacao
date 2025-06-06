using TrabalhoAv1.Models;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoAv1.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Estado> Estados { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
}