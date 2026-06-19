using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Core
{
    public class UserManager
    {
        public static string path = "results.json";
        public static List<User> GetAll()
        {
            if (FileProvider.Exists(path))
            {
                var jsonData = FileProvider.GetValue(path);
                return JsonConvert.DeserializeObject<List<User>>(jsonData);
            }

            return new List<User>() ;
            
        }

        public static void Add(User newUser)
        {
            var users = GetAll();
            users.Add(newUser);

            var jsonData = JsonConvert.SerializeObject(users);
            FileProvider.Replace(path, jsonData);
        }
    }
}
