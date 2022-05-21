using System;
using Models.PhoneClasses;

namespace Parser.Repositories
{
    public class PhoneTypeParser : Parser<Models.PhoneClasses.Type>
    {
        public PhoneTypeParser(string filepath) : base(filepath)
        {
        }
    }
}
