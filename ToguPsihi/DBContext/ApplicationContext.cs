using Microsoft.EntityFrameworkCore;
using ToguPsihi.Models;

public class ApplicationContext : DbContext
{
    public DbSet<TestOne> TestOnes { get; set; }
     
    public ApplicationContext()
    {
        if (Database.EnsureCreated() == true)
        {
            Console.WriteLine("no exist");
        }
        else
        {
            Console.WriteLine("exist");
        }
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=testOne.db");
    }
}