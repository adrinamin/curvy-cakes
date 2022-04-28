namespace CurvyCakes.Presentation.Data;

public interface IAccountService
{
    IList<AccountDto> GetAccounts();

    AccountDto GetAccountsById(Guid id);
}