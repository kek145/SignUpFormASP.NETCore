using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<Users> Users { get; set; }
    public ApplicationContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BEHCHLL;Initial Catalog=Usersdb;Integrated Security=True; TrustServerCertificate = True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Users>().HasKey(td => td.UserId);
}