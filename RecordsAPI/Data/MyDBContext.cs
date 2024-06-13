using Microsoft.EntityFrameworkCore;


namespace RecordsAPI.Data
{
    public class MyDBContext : DbContext
    {

        public DbSet<Account> Accounts { get; set; }
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(new Account()
            {
                Id = 1,
                UserName = "User",
                Password = "Password",
            });
        }
    }
}
