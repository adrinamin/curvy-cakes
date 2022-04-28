using System.ComponentModel.DataAnnotations;

namespace CurvyCakes.Presentation.Data;

public record EntryDto(Guid Id, [Required] EntryType Type,[Required] double Amount, [Required] AccountDto Account, BudgetDto Budget);