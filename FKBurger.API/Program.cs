using FKBurger.API.Hubs;
using FKBurger.API.IoC;
using FKBurger.DataAccess.Concrete;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(opt => opt.AddPolicy("CorsPolicy", build => build.AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed((host) => true).AllowCredentials()));

builder.Services.AddSignalR();

builder.Services.AddDbContext<FKBurgerDBContext>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddIoCServices();//AddScoped'larý tuttuðum class.

builder.Services.AddControllersWithViews().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");

app.Run();