using Microsoft.EntityFrameworkCore;
using ToguPsihi.Models;

public class ApplicationContext : DbContext
{
    public DbSet<TestOne> TestOnes { get; set; }
     
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=TestOne.db");
    }
}