using RecordsAPI.Repository;

public class AccountService
{
    private readonly IAccountRepository _accountRepository;

    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Account> GetAccountByIdAsync(int id)
    {
        return await _accountRepository.GetByIdAsync(id);
    }

    public async Task<List<Account>> GetAllAccountsAsync()
    {
        return await _accountRepository.GetAllAsync();
    }
}
