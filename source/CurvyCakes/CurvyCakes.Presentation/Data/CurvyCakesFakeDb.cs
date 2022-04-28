namespace CurvyCakes.Presentation.Data;

public class CurvyCakesFakeDb
{
    public CurvyCakesFakeDb()
    {
        this.Accounts = new List<AccountDto>();
        this.Accounts.Add(AccountDto.CreateDefault());
        this.Accounts.Add(AccountDto.CreateDefault());
        this.Accounts.Add(AccountDto.CreateDefault());
    }

    public List<AccountDto> Accounts { get; }
}