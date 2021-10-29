using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class UserRepository
    {
        public static List<User>  Users = new List<User>();
        
        public static void Create(User user)
        {
            Users.Add(user);
        }
        public static void Update(int id, User user)
        {
            Users[id] = user;
        }
        public static void Delete(int id)
        {
            Users.RemoveAt(id);
        }
        public static User GetOne(int id)
        {
            return Users.Find(u => u.Id == id);
        }

        public static List<User> GetAll()
        {
            return Users.ToList();
        }
        public static int NextId()
        {
            return Users.Count;
        }
    }
}
