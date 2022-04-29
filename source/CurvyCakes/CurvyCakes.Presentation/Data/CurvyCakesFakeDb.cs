namespace CurvyCakes.Presentation.Data;

public class CurvyCakesFakeDb
{
    public CurvyCakesFakeDb()
    {
        var entriesAcc1 = new List<EntryDto>();
        var budgetsAcc1 = new List<BudgetDto>();

        var account1 = new AccountDto
        {
            Id = Guid.NewGuid(),
            Name = "Main Account",
            Amount = 1500.0,
            Bank = "Credit Suisse",
            Budgets = budgetsAcc1,
            Entries = entriesAcc1,


        };

        var account2 = new AccountDto
        {
            Id = Guid.NewGuid(),
            Name = "Vacation Account",
            Amount = 500.0,
            Bank = "Revolut",
            Budgets = budgetsAcc1,
            Entries = entriesAcc1,


        };

        var account3 = new AccountDto
        {
            Id = Guid.NewGuid(),
            Name = "Savings Account",
            Amount = 2500.0,
            Bank = "N26",
            Budgets = budgetsAcc1,
            Entries = entriesAcc1,


        };
        this.Accounts = new List<AccountDto>
        {
            account1,
            account2,
            account3
        };

        
        var budgetDto = new BudgetDto(Guid.NewGuid(), "Food", 500.0, account1, entriesAcc1);
        var budgetDto2 = new BudgetDto(Guid.NewGuid(), "Going Out", 200.0, account1, entriesAcc1);
        var budgetDto3 = new BudgetDto(Guid.NewGuid(), "Random", 300.0, account1, entriesAcc1);
        var budgetDto4 = new BudgetDto(Guid.NewGuid(), "Random2", 300.0, account1, entriesAcc1);
        var budgetDto5 = new BudgetDto(Guid.NewGuid(), "Random3", 300.0, account1, entriesAcc1);
        var budgetDto6 = new BudgetDto(Guid.NewGuid(), "Random4", 300.0, account1, entriesAcc1);
        var budgetDto7 = new BudgetDto(Guid.NewGuid(), "Random5", 300.0, account1, entriesAcc1);
        budgetsAcc1.Add(budgetDto);
        budgetsAcc1.Add(budgetDto2);
        budgetsAcc1.Add(budgetDto3);
        budgetsAcc1.Add(budgetDto4);
        budgetsAcc1.Add(budgetDto5);
        budgetsAcc1.Add(budgetDto6);
        budgetsAcc1.Add(budgetDto7);

        var entryDto1 = new EntryDto(Guid.NewGuid(), EntryType.Expense, 15.0, account1, budgetDto);
        var entryDto2 = new EntryDto(Guid.NewGuid(), EntryType.Expense, 35.0, account1, budgetDto);
        var entryDto3 = new EntryDto(Guid.NewGuid(), EntryType.Expense, 25.0, account1, budgetDto);
        entriesAcc1.Add(entryDto1);
        entriesAcc1.Add(entryDto2);
        entriesAcc1.Add(entryDto3);

        this.Budgets = new List<BudgetDto>();
        this.Budgets.AddRange(budgetsAcc1);

        this.Entrys = new List<EntryDto>();
        this.Entrys.AddRange(entriesAcc1);
    }

    public List<AccountDto> Accounts { get; }

    public List<BudgetDto> Budgets { get; }

    public List<EntryDto> Entrys { get; }
}