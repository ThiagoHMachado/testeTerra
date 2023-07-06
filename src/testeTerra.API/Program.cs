using testeTerra.ACL.Facade;
using testeTerra.ACL.Facade.Contract;
using testeTerra.ACL.Gateways;
using testeTerra.ACL.Gateways.Contract;
using testeTerra.Service.Contract;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Injeção

#region Facade
builder.Services.AddScoped<IBranchsFacade,BranchsFacade>();
builder.Services.AddScoped<IRepositoryFacade, RepositoryFacade>();
builder.Services.AddScoped<IWebHookFacade, WebHookFacade>();
#endregion
#region Gateway
builder.Services.AddScoped<IBranchsGateway, BranchsGateway>();
builder.Services.AddScoped<IRepositoryGateway, RepositoryGateway>();
builder.Services.AddScoped<IWebHookGateway, WebHookGateway>();
#endregion
#region Service
builder.Services.AddScoped<testeTerra.Service.Contract.IBranchsService, testeTerra.Service.Services.BranchsService>();
builder.Services.AddScoped<testeTerra.Service.Contract.IRepositoryService, testeTerra.Service.Services.RepositoryService>();
builder.Services.AddScoped<testeTerra.Service.Contract.IWebHookService, testeTerra.Service.Services.WebHookService>();
#endregion
#region GitHub
builder.Services.AddScoped<testeTerra.GitHub.Contract.IBranchsService, testeTerra.GitHub.Services.BranchsService>();
builder.Services.AddScoped<testeTerra.GitHub.Contract.IRepositoryService, testeTerra.GitHub.Services.RepositoryService>();
builder.Services.AddScoped<testeTerra.GitHub.Contract.IWebHookService, testeTerra.GitHub.Services.WebHookService>();
#endregion

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
