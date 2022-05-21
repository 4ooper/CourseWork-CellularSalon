using Models;
using Models.PhoneClasses;

namespace BLL.Interfaces
{
    public interface ISales
    {
        bool CreateSale(User user, Phone phone);
    }
}
