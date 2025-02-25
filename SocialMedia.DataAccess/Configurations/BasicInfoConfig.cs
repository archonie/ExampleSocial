using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.DataAccess.Configurations;

internal class BasicInfoConfig: IEntityTypeConfiguration<BasicInfo>
{
    public void Configure(EntityTypeBuilder<BasicInfo> builder)
    {
    }
}