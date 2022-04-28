namespace CurvyCakes.Presentation.Data;

public class BudgetService : IBudgetService
{
    private readonly CurvyCakesFakeDb curvyCakesFakeDb;

    public BudgetService(CurvyCakesFakeDb curvyCakesFakeDb)
    {
        this.curvyCakesFakeDb = curvyCakesFakeDb;
    }

    public BudgetDto GetBudgetById(Guid id)
    {
        ArgumentNullException.ThrowIfNull(id);
        return this.curvyCakesFakeDb.Budgets.Single(b => b.Id == id);
    }
}