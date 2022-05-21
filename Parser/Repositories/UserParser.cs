using Models;

namespace Parser
{
    /// <summary>
    /// Класс для чтения и записи пользователей
    /// </summary>
    public class UserParser : Parser<User>
    { 
        public UserParser(string filepath) : base(filepath)
        {
        }
    }
}
