using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialMedia.DataAccess.Configurations;
using SocialMedia.Domain.Aggregates.PostAggregate;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.DataAccess;

public class DataContext: IdentityDbContext
{
    public DataContext(DbContextOptions<DataContext> options): base(options)
    {
        
    }

    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PostCommentConfig());
        modelBuilder.ApplyConfiguration(new PostInteractionConfig());
        modelBuilder.ApplyConfiguration(new UserProfileConfig());
        modelBuilder.ApplyConfiguration(new IdentityUserLoginConfig());
        modelBuilder.ApplyConfiguration(new IdentityUserRoleConfig());
        modelBuilder.ApplyConfiguration(new IdentityUserTokenConfig());
    }
}