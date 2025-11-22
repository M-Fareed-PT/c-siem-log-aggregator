using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> opts): base(opts) {}
    public DbSet<LogEntry> Logs { get; set; }
    public DbSet<Alert> Alerts { get; set; }
}
