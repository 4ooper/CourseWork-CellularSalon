using System.Collections.Generic;
using System.IO;
using Models;
using Newtonsoft.Json;

namespace Parser
{
    /// <summary>
    /// Класс для чтения и записи продаж
    /// </summary>
    public class SaleParser : Parser<Sale>
    {
        public SaleParser(string filepath) : base(filepath)
        {
        }
    }
}
