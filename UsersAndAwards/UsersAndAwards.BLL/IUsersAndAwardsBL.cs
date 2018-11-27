using Entities;
using System.Collections.Generic;

namespace UsersAndAwards.BLL
{
    public interface IUsersAndAwardsBL
    {
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int ID);
        IEnumerable<User> GetAllUsers();

        void AddAward(Award award);
        void UpdateAward(Award award);
        void DeleteAward(int ID);
        IEnumerable<Award> GetAllAwards();
    }
}
