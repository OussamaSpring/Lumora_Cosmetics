using Persistence;


var builder = WebApplication.CreateBuilder(args);

// Retrieve the connection string from configuration
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Initialize the DatabaseHelper with the connection string
DatabaseHelper.Initialize(connectionString);
var app = builder.Build();

app.UseHttpsRedirection();
// Use app as needed
app.Run();