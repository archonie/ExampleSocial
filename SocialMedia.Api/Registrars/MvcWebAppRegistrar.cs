using Asp.Versioning.ApiExplorer;

namespace SocialMedia.Api.Registrars;

public class MvcWebAppRegistrar: IWebApplicationRegistrar
{
    public void RegisterPipelineComponents(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger(); 
            app.UseSwaggerUI(options => 
            { 
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>(); 
                foreach (var description in provider.ApiVersionDescriptions) 
                { 
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.ApiVersion.ToString());
                } 
            });
        }
        
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

       
    }
}