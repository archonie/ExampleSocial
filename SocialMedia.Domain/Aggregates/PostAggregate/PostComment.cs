namespace SocialMedia.Domain.Aggregates.PostAggregate;

public class PostComment
{
    private PostComment()
    {
        
    }
    public Guid CommentId { get; private set; }
    public Guid PostId { get; private set; }
    public Guid UserProfileId { get; private set; } 
    public string Text { get; private set; }
    public DateTime DateCreated { get; private set; }
    public DateTime LastModified { get; private set; }
    
    // Factories
    public static PostComment CreatePostComment(Guid postId, Guid userProfileId, string text)
    {
        return new PostComment
        {
            UserProfileId = userProfileId,
            PostId = postId,
            Text = text,
            DateCreated = DateTime.UtcNow,
            LastModified = DateTime.UtcNow
        };
    }
    
    // Public methods
    public void UpdateCommentText(string newText)
    {
        Text = newText;
        LastModified = DateTime.UtcNow;
    }
}