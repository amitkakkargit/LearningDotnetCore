using Infrastructure.Repository;
using OnionArchitecture.Domain;

namespace OnionArchitecture.Service
{
    public class UserProfileService: IUserProfileService
    {
        private IRepository<UserProfile> userProfileRepository;
 
        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {          
            this.userProfileRepository = userProfileRepository;
        }
 
        public UserProfile GetUserProfile(long id)
        {
            return userProfileRepository.Get(id);
        }

        UserProfile IUserProfileService.GetUserProfile(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}