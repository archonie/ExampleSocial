using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Domain.Aggregates.PostAggregate;

namespace SocialMedia.DataAccess.Configurations;

internal class PostCommentConfig: IEntityTypeConfiguration<PostComment>
{
    public void Configure(EntityTypeBuilder<PostComment> builder)
    {
        builder.HasKey(pc => pc.CommentId);
    }
}