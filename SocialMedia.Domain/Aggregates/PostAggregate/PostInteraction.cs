namespace SocialMedia.Domain.Aggregates.PostAggregate;

public class PostInteraction
{
    private PostInteraction()
    {
        
    }
    
    public Guid InteractionId { get; private set; }
    public Guid PostId { get; private set; }
    public InteractionType Type { get; private set; }
    
    // Factories
    public static PostInteraction CreatePostInteraction(Guid postId, InteractionType type)
    {
        return new PostInteraction
        {
            PostId = postId,
            Type = type
        };
    }
    
}