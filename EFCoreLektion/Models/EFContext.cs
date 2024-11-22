using Microsoft.EntityFrameworkCore;

using System.Runtime;

namespace EFCoreLektion.Models;
public class EFContext : DbContext
{
    private const string connectionString = 
        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreLektionDemoDB;Integrated Security=True;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    public DbSet<Product> Products { get; set; }
}
