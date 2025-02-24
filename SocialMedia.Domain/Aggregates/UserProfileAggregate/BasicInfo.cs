namespace SocialMedia.Domain.Aggregates.UserProfileAggregate;

public class BasicInfo
{
    private BasicInfo()
    {
        
    }
    
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string EmailAddress { get; private set; }
    public string Phone { get; private set; }
    public string CurrentCity { get; private set; }
    public DateTime DateOfBirth { get; private set; }

    public static BasicInfo CreateBasicInfo(string firstName, string lastName, string email, string phone,
        string currentCity, DateTime dateOfBirth)
    {
        // TODO: Implement validation, Error handling strategies, error notification strategies
        return new BasicInfo
        {
            FirstName = firstName,
            LastName = lastName,
            EmailAddress = email,
            Phone = phone,
            CurrentCity = currentCity,
            DateOfBirth = dateOfBirth
        };
    }
}