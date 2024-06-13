namespace RecordsAPI.Repository;
using Microsoft.EntityFrameworkCore;
using RecordsAPI.Data;

public class AccountRepository : IAccountRepository
{
    private readonly MyDBContext _dbContext;

    public AccountRepository(MyDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Account> GetByIdAsync(int id)
    {
        return await _dbContext.Set<Account>().FindAsync(id);
    }

    public async Task<List<Account>> GetAllAsync()
    {
        return await _dbContext.Set<Account>().ToListAsync();
    }

}
