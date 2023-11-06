namespace DefaultNamespace;

public class UsersDbDao : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Batch> Batch { get; set; }
    public DbSet<DateTime> DateTime { get; set; }
    public DbSet<Error> Error { get; set; }
    public DbSet<Machine> Machine { get; set; }
    public DbSet<Types> Types { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Todo.db");
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);            
    }
}