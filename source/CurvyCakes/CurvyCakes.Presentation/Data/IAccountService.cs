namespace CurvyCakes.Presentation.Data;

public interface IAccountService
{
    IList<AccountDto> GetAll();
    AccountDto GetById(Guid id);
    void Add(AccountDto account);
    void DeleteById(Guid id);
    void Update(AccountDto account);
}