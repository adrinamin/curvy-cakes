namespace CurvyCakes.Presentation.Data;

public record AccountDto(Guid Id, string Name, double Amount, string Bank, IList<EntryDto> Entries, IList<BudgetDto> Budgets)
{
    public static AccountDto CreateDefault()
    {
        return new(
            Guid.NewGuid(),
            "My Account",
            100.0d,
            "Credit Suisse",
            new List<EntryDto>(),
            new List<BudgetDto>());
    }
}