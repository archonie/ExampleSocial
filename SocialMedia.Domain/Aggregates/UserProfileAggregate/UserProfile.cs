namespace SocialMedia.Domain.Aggregates.UserProfileAggregate;

public class UserProfile
{
    private UserProfile()
    {
        
    }
    
    public Guid UserProfileId { get; private set; }
    public string IdentityId { get; private set; }
    public BasicInfo BasicInfo { get; private set; }
    public DateTime DateCreated { get; private set; }
    public DateTime LastModified { get; private set; }

    // Factory Method
    public static UserProfile CreateUserProfile(string identityId, BasicInfo basicInfo)
    {
        // TODO: Add Validation, error handling strategies, error notification strategies
        return new UserProfile
        {
            IdentityId = identityId,
            BasicInfo = basicInfo,
            DateCreated = DateTime.UtcNow,
            LastModified = DateTime.UtcNow
        };
    }
    
    // Public methods

    public void UpdateBasicInfo(BasicInfo newInfo)
    {
        BasicInfo = newInfo;   
        LastModified = DateTime.UtcNow;
    }
}