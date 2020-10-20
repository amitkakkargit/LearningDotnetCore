namespace daysix.Models
{
    public interface IDataRepository
    {
         void Add(Membership temp);
         bool LoginValidate(string username,string password);
    }
}