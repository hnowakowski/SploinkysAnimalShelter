using MySql.Data.MySqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// MySQL setup (temporary just to check if it works)
var dbConnectionStr = builder.Configuration.GetValue<string>("dbstring");
var connection = new MySqlConnection(dbConnectionStr);
await connection.OpenAsync();
var command = new MySqlCommand("SELECT * FROM cat;", connection);
var reader = await command.ExecuteReaderAsync();

while (await reader.ReadAsync())
{
    Console.WriteLine(Convert.ToString(reader["id"]) + reader["name"], reader["color"]);
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
