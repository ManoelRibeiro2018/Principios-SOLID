using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public User(int id, string name, string lastName, string address)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Address = address;
        }
    }
}
