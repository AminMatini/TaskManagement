namespace TaskManagement.Infra.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public virtual DbSet<User> Users { get; set; } = null!;
    public virtual DbSet<Domain.Entities.Task> Tasks { get; set; } = null!;
    public virtual DbSet<TaskItem>? TaskItems { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.HasDefaultSchema("dbo");

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
