
using System.Windows.Forms;

namespace BLL.Interfaces
{
    public interface IPhoto
    {
        bool ChoosePreviewPhoto(OpenFileDialog fileDialog, Button button);
        bool ChooseMainPhotos(OpenFileDialog fileDialog, Button button);
    }
}
