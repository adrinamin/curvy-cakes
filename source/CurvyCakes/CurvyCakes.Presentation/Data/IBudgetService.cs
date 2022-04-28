namespace CurvyCakes.Presentation.Data;

public interface IBudgetService
{
    BudgetDto GetBudgetById(Guid id);
}