using Microsoft.AspNetCore.Mvc;
using RecordsAPI.Data;
using Microsoft.VisualBasic;


namespace RecordsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly AccountService _accountService;

        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAccounts()
        {
            var accounts = await _accountService.GetAllAccountsAsync();

            List<AccountDto> accountList = accounts.ConvertAll(account => new AccountDto
            {
                Id = account.Id,
                UserName = account.UserName,
            });


            return Ok(accountList);
        }

    }
}
