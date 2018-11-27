using System.Collections.Generic;
using Entities;
using UsersAndAwards.DAL;

namespace UsersAndAwards.BLL
{
    public class UsersAndAwardsBL : IUsersAndAwardsBL
    {
        IUsersAndAwarsDAL usersAndAwars = new UsersAndAwardsDAL();

        public void AddAward(Award award)
        {
            usersAndAwars.AddAward(award);
        }

        public void AddUser(User user)
        {
            usersAndAwars.AddUser(user);
        }

        public void DeleteAward(int ID)
        {
            usersAndAwars.DeleteAward(ID);
        }

        public void DeleteUser(int ID)
        {
            usersAndAwars.DeleteUser(ID);
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return usersAndAwars.GetAllAwards();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return usersAndAwars.GetAllUsers();
        }

        public void UpdateAward(Award award)
        {
            usersAndAwars.UpdateAward(award);
        }

        public void UpdateUser(User user)
        {
            usersAndAwars.UpdateUser(user);
        }
    }
}
