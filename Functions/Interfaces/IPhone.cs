using Models.PhoneClasses;
using System.Windows.Forms;

namespace BLL.Interfaces
{
    public interface IPhone
    {
        bool AddPhone(Phone phone);
        bool UpdatePhone(Phone prevPhone, Phone phone);
        bool DeletePhone(Phone phone);
        string[] getStringFolders(Button choosePhotosButton, string name);
    }
}
