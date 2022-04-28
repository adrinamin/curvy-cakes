using System.ComponentModel.DataAnnotations;

namespace CurvyCakes.Presentation.Data;

public record BudgetDto(Guid Id, string Name, double Amount, [Required] AccountDto Account, IList<EntryDto> Entries);