using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Domain.Aggregates.PostAggregate;

public class Post
{
    private readonly List<PostComment> _comments = new List<PostComment>();
    private readonly List<PostInteraction> _interactions = new List<PostInteraction>();
    private Post()
    {
    }
    public Guid PostId { get; private set; }
    public Guid UserProfileId { get; private set; }
    public UserProfile UserProfile { get; private set; }
    public string TextContent { get; private set; }
    public DateTime DateCreated { get; private set; }
    public DateTime LastModified { get; private set; }
    public IEnumerable<PostComment> Comments { get { return _comments; } }
    public IEnumerable<PostInteraction> Interactions { get { return _interactions; } }

    // Factories
    public static Post CreatePost(Guid userProfileId, string textContent)
    {
        return new Post
        {
            UserProfileId = userProfileId,
            TextContent = textContent,
            DateCreated = DateTime.UtcNow,
            LastModified = DateTime.UtcNow,
        };
    }

    // Public Methods
    public void UpdatePostText(string newText)
    {
        TextContent = newText;
        LastModified = DateTime.UtcNow;
    }

    public void AddPostComment(PostComment newComment)
    {
        _comments.Add(newComment);
        LastModified = DateTime.UtcNow;
    }

    public void RemoveComment(PostComment toRemove)
    {
        _comments.Remove(toRemove);
        LastModified = DateTime.UtcNow;
    }

    public void AddInteraction(PostInteraction newInteraction)
    {
        _interactions.Add(newInteraction);
        LastModified = DateTime.UtcNow;
    }

    public void RemoveInteraction(PostInteraction toRemove)
    {
        _interactions.Remove(toRemove);
        LastModified = DateTime.UtcNow;
    }
}