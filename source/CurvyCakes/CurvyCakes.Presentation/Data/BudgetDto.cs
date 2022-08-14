using System.ComponentModel.DataAnnotations;

namespace CurvyCakes.Presentation.Data;

public record BudgetDto
{
    public BudgetDto()
    {
        Id = Guid.NewGuid();
        Name = string.Empty;
        Amount = 0.0d;
        Account = new AccountDto();
        Entries = new List<EntryDto>();
    }

    public BudgetDto(Guid guid, string v1, double v2, AccountDto account1, List<EntryDto> entriesAcc1)
    {
        Id = guid;
        Name = v1;
        Amount = v2;
        Account = account1;
        Entries = entriesAcc1;
    }

    public Guid Id { get; set; }
    [Required]
    [StringLength(255, MinimumLength = 2, ErrorMessage = "Give the budget a proper name.")]
    public string Name { get; set; }
    public double Amount { get; set; }
    public AccountDto Account { get; set; }
    public IList<EntryDto> Entries { get; set; }

}