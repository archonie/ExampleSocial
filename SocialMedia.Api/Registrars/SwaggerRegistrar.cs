using SocialMedia.Api.Options;

namespace SocialMedia.Api.Registrars;

public class SwaggerRegistrar: IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.ConfigureOptions<ConfigureSwaggerOptions>(); 
        builder.Services.AddSwaggerGen();
    }
}