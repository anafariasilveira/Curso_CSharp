using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace ProjetFinal.Api.Infrastructure
{
    internal class AppSwaggerConfiguration
    {
        public static void Options(SwaggerGenOptions options)
        {
            var openApiInfo = new OpenApiInfo();

            openApiInfo.Title = "BTG Faz Tech - Turma 1038";
            openApiInfo.Description = "Projeto Final do Módulo Web III - WebAPI";
            
            openApiInfo.License = new OpenApiLicense
            {
                Name = "MIT",
                Url = new Uri(@"http://www.mit.com/license")
            };

            openApiInfo.Contact = new OpenApiContact()
            {
                Name = "Turma 1038",
                Email = "contato@turma1038.com"
            };

            options.SwaggerDoc("v1", openApiInfo);

            var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var path = Path.Combine(AppContext.BaseDirectory, fileName);

            options.IncludeXmlComments("teste.xml", true);
        }
    }
}