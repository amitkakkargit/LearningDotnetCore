using OnionArchitecture.Domain;

namespace OnionArchitecture.Service
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);
    }
}