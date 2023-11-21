using CS322_DZ07.model;
using System.Collections.Generic;

namespace CS322_DZ07.repository
{
    internal interface UserRepository
    {
        List<User> FindAll();
        void EditById(long id,string firstName, string lastName,int age);
        bool DeleteById(long id);
        User AddUser(User user);
    }
}

