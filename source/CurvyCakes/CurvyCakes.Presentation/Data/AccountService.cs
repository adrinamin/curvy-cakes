namespace CurvyCakes.Presentation.Data;

public class AccountService : IAccountService
{
    private readonly CurvyCakesFakeDb curvyCakesFakeDb;

    public AccountService(CurvyCakesFakeDb curvyCakesFakeDb)
    {
        this.curvyCakesFakeDb = curvyCakesFakeDb;
    }

    public IList<AccountDto> GetAll()
    {
        return this.curvyCakesFakeDb.Accounts;
    }

    public AccountDto GetById(Guid id)
    {
        ArgumentNullException.ThrowIfNull(id);
        return this.curvyCakesFakeDb.Accounts.Single(a => a.Id == id);
    }

    public void Add(AccountDto account)
    {
        ArgumentNullException.ThrowIfNull(account);
        this.curvyCakesFakeDb.Accounts.Add(account);
    }

    public void DeleteById(Guid id)
    {
        ArgumentNullException.ThrowIfNull(id);
        var accountDto = this.GetById(id);
        this.curvyCakesFakeDb.Accounts.Remove(accountDto);
    }
}