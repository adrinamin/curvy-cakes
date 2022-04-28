namespace CurvyCakes.Presentation.Data;

public record AccountDto(Guid Id, string Name, double Amount, string Bank)
{
    public static AccountDto CreateDefault()
    {
        return new(Guid.NewGuid(), "My Account", 100.0d, "Credit Suisse");
    }
}