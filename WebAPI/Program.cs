using Serilog;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSingleton<ILogOperation, LogOperation>();

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseSerilogRequestLogging();
app.MapControllers();

app.Run();