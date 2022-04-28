namespace CurvyCakes.Presentation.Data;

public class AccountService : IAccountService
{
    private readonly CurvyCakesFakeDb curvyCakesFakeDb;

    public AccountService(CurvyCakesFakeDb curvyCakesFakeDb)
    {
        this.curvyCakesFakeDb = curvyCakesFakeDb;
    }

    public IList<AccountDto> GetAccounts()
    {
        return this.curvyCakesFakeDb.Accounts;
    }

    public AccountDto GetAccountsById(Guid id)
    {
        ArgumentNullException.ThrowIfNull(id);
        return this.curvyCakesFakeDb.Accounts.Single(a => a.Id == id);
    }
}