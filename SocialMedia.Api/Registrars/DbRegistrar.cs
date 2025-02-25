using Microsoft.EntityFrameworkCore;
using SocialMedia.DataAccess;

namespace SocialMedia.Api.Registrars;

public class DbRegistrar: IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        var cs = builder.Configuration.GetConnectionString("SocialMediaCS");
        builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(cs));
    }
}