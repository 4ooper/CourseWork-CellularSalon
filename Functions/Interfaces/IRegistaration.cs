using Models;

namespace BLL.Interfaces
{
    public interface IRegistaration
    {
        bool ParseFields(string name, string password, string email);
        bool CreateUser(User user);
    }
}
