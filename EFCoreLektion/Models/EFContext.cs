using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

using System.Runtime;

namespace EFCoreLektion.Models;
public class EFContext : DbContext
{
    private const string connectionString = 
        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreLektionDemoDB;Integrated Security=True;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString)
            //.LogTo(Console.WriteLine, new[] {RelationalEventId.CommandExecuted})    //Show SQL commands
            ;
    }

    public DbSet<Product> Products { get; set; }
}
