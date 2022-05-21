using Models;

namespace BLL.Interfaces
{
    internal interface IUser
    {
        User CreateUser(string position, string email, string password, string name);
        bool UpdateUser(User incomeUser, User newUser);
    }
}
