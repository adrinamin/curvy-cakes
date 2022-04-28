namespace CurvyCakes.Presentation.Data;

public class AccountService : IAccountService
{
    private readonly CurvyCakesFakeDb curvyCakesFakeDb;

    public AccountService()
    {
        this.curvyCakesFakeDb = new CurvyCakesFakeDb();
    }
    public IList<AccountDto> GetAccounts()
    {
        return this.curvyCakesFakeDb.Accounts;
    }
}