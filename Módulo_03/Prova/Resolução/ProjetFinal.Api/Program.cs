using ProjetFinal.Api.Infrastructure;
using ProjetFinal.Api.Persistence;
using ProjetFinal.Api.Services;

namespace ProjetFinal.Api;

public class Program
{
    public static IConfiguration Config { get; private set; }

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        Config = builder.Configuration;

        builder.Services.AddCors();
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(AppSwaggerConfiguration.Options);
        builder.Services.AddDbContext<IAppDbContext, AppDbContext>();
        builder.Services.AddTransient<IQuoteService, QuoteService>();

       var app = builder.Build();

        app.UseCors(options => options
       .AllowAnyOrigin()
       .AllowAnyMethod()
       .AllowAnyHeader());

        app.ApplyMigrations();
        app.UseCors(AppCorsConfiguration.AllowAnything);
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}
