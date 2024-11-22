using EFCoreConventions.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConventions;
public class EFContext : DbContext
{
    private const string connectionString =
        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreLektionConventionsDB;Integrated Security=True;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString)
            //.LogTo(Console.WriteLine, new[] {RelationalEventId.CommandExecuted})    //Show SQL commands
            ;
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerAddress> CustomerAddresses { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DbTypeTest> DbTypeTests { get; set; }
}

