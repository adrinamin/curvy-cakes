namespace CurvyCakes.Infrastructure;

public class InfrastructureInitializer
{
    private readonly DolderDbContext context;

    public InfrastructureInitializer(DolderDbContext context)
    {
        this.context = context;
    }

    public async Task Initialize()
    {
        await this.context.Database.MigrateAsync();
    }
}