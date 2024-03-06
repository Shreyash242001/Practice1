global using Microsoft.EntityFrameworkCore;
namespace MyApp.Models;
public class SiteDbContext : DbContext
{
    public DbSet<Emp> Employee { get; set; }


    // public SiteDbContext()
    // {
    //     Database.EnsureCreated();
    // }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop4;User ID=dac4;Password=Dac4@1234;Encrypt=False");
    // }
}