using FashionTrend.API.Extensions;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace FashionTrend.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.ConfigurePersistenceApp(builder.Configuration);
            builder.Services.ConfigureApplicationApp();
            builder.Services.ConfigureCorsPolicy();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                var openApiInfo = new OpenApiInfo();

                openApiInfo.Title = "API FashionTrend - Grupo de Sustentabilidade";
                openApiInfo.Description = "Documenta��o da API FashionTrend para o m�dulo de Arquitetura de software 2 do Grupo de Sustentabilidade, oferece a funcionalidade para costureiras(fornecedores) se cadastrarem e acessarem oportunidades de servi�o disponibilizadas pela Fashion Trend.";

                openApiInfo.Contact = new OpenApiContact()
                {
                    Name = "Turma 1038"
                };

                options.SwaggerDoc("v1", openApiInfo);

                var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var path = Path.Combine(AppContext.BaseDirectory, fileName);
                options.IncludeXmlComments(path, true);
            });
            builder.Services.AddLogging(logging =>
            {
                logging.AddConsole();
                logging.AddDebug();
            });
            var app = builder.Build();

            BD.CreateDataBase(app);

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors();
            app.MapControllers();
            app.Run();
        }
    }
}