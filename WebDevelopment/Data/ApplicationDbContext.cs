using Microsoft.EntityFrameworkCore;
using WebDeveloperExceptionPageExtensions;
using WebDevelopment.Models;

namespace WebDevelopment;

public class ApplicationDbContext(IConfiguration configuration) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder
            .UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<User> User { get; set; }
    public DbSet<UserAccount> UserAccounts { get; set; }
    
}