using System.Collections.Generic;
using CustomMiddleWare.Model;

namespace CustomMiddleware.Repository
{
    public interface  IContactsRepository
    {
         
        void Add(Contacts item);
        IEnumerable<Contacts> GetAll();
        Contacts Find(string key);
        void Remove(string Id);
        void Update(Contacts item);

        bool CheckValidUserKey(string reqkey);
    }
}