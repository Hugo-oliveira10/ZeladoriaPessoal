using ZeladoriaUrbana.Api.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddProjectServices(
    builder.Configuration
);

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

//p.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

builder.Services.AddSwaggerGen();

app.UseSwagger();

app.UseSwaggerUI();
