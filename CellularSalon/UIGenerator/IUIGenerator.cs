using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parser.Repositories;
using Parser;
using Models.PhoneClasses;
using System.Drawing;
using System.IO;

namespace CellularSalon.UIGenerator
{
    /// <summary>
    /// Интерфейс для описания автогенераторов интерфейса
    /// </summary>
    public interface IUIGenerator
    {
        void Generate();
    }
}
