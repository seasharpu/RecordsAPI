using RecordsAPI.Data;
using Microsoft.EntityFrameworkCore;
using RecordsAPI.Repository;



var builder = WebApplication.CreateBuilder(args);



var config = new ConfigurationBuilder()
   .AddUserSecrets<Program>()
   .Build();

// Retrieve MySQL connection string
string MySQLConnectionString = config["MySQLConnectionString"];

// Add services to the container.
builder.Services.AddDbContext<MyDBContext>(options =>
{
    options.UseMySql(MySQLConnectionString, new MySqlServerVersion(new Version(8, 0, 28)));
});


builder.Services.AddHttpClient();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<AccountService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseAuthorization();

app.MapControllers();

app.Run();
