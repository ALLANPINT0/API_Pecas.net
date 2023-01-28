using API_PECAS.Adapters.MongoDB.Extensions;
using API_PECAS.Application;
using API_PECAS.Route;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMongoDB();
builder.Services.AddScoped<IUseCase, UseCases>();

var app = builder.Build();

 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.AddEndpoints();

app.Run();

