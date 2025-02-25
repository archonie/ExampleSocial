using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.DataAccess.Configurations;

internal class UserProfileConfig: IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.OwnsOne<BasicInfo>(up => up.BasicInfo);
    }
}