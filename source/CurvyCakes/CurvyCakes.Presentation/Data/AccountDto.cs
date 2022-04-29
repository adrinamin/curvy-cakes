using System.ComponentModel.DataAnnotations;

namespace CurvyCakes.Presentation.Data;

public class AccountDto
{
    public AccountDto()
    {
        Id = Guid.NewGuid();
        Name = string.Empty;
        Amount = 0.0d;
        Bank = string.Empty;
        Entries = new List<EntryDto>();
        Budgets = new List<BudgetDto>();
    }

    public Guid Id { get; set; }
    [Required]
    [StringLength(255, MinimumLength = 2, ErrorMessage = "Give the account a proper name.")]
    public string Name { get; set; }
    public double Amount { get; set; }
    [Required]
    [StringLength(255, MinimumLength = 2, ErrorMessage = "The account must belong to a bank")]
    public string Bank { get; set; }
    public IList<EntryDto> Entries { get; set; }
    public IList<BudgetDto> Budgets { get; set; }
}