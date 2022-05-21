using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Interfaces
{
    /// <summary>
    /// Интерфейс описания основных функций парсера
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IParser<T>
    {
        List<T> GetData();
        bool writeData(List<T> data);
    }
}
