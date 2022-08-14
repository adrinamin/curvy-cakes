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

    public void Add(BudgetDto budget)
    {
        ArgumentNullException.ThrowIfNull(budget);
        this.curvyCakesFakeDb.Budgets.Add(budget);
        this.curvyCakesFakeDb.UpdateDatabase();
    }
}