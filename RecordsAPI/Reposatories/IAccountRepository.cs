namespace RecordsAPI.Repository;

public interface IAccountRepository
{
    Task<Account> GetByIdAsync(int id);
    Task<List<Account>> GetAllAsync();
}