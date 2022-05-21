using Newtonsoft.Json;
using Parser.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace Parser
{
    /// <summary>
    /// Абстрактный класс для описания основных функций парсеров
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class Parser<TEntity> : IParser<TEntity>
    {
        private readonly string filepath;

        public List<TEntity> entities;
        public Parser(string filepath)
        {
            this.filepath = filepath;
            this.entities = GetData();
        }

        public List<TEntity> GetData()
        {
            List<TEntity> data = new List<TEntity>();

            using (StreamReader file = File.OpenText(filepath))
            {
                JsonSerializer serializer = new JsonSerializer();
                data = (List<TEntity>)serializer.Deserialize(file, typeof(List<TEntity>));
            }
            
            entities = data;
            return data;
        }

        public bool writeData(List<TEntity> entities)
        {
            using (StreamWriter writer = new StreamWriter(filepath, false))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, entities);
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
    }
}
