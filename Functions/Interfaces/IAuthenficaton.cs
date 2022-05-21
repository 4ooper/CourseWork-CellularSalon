using Models;

namespace BLL.Interfaces
{
    public interface IAuthenficaton
    {
        User GetItem(string email, string password);
    }
}
