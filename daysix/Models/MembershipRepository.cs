using System.Linq;
namespace daysix.Models
{
    public class Membershiprepository : IDataRepository
    {
        MembershipContext tempcontext;
        void IDataRepository.Add(Membership temp)
        {
            tempcontext.Add(temp);
            tempcontext.SaveChanges();

        }

        bool IDataRepository.LoginValidate(string username, string password)
        {

            var temp = tempcontext.users.Where(s => s.username == username && s.password == password).FirstOrDefault();
            if (temp == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Membershiprepository(MembershipContext t)
        {
            this.tempcontext = t;
        }
    }

}