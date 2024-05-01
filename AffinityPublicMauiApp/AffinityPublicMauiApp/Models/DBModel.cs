using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffinityPublicMauiApp.Models
{
    public interface IDatabase
    {
        List<T> Get<T>(string key);
        void AddItem<T>(T item);
    }
    public class DBModel : IDatabase
    {
        public List<T> Get<T>(string key) { 
            // TODO: Get valz from db
            return new List<T>();
        }

        public void AddItem<T>(T item)
        {
            // TODO: Add item to db
        }
    }
}
