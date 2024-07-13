using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectC_.UserPanel
{
    public class User
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public DateTime BirthDay { get; set; }
        public string? Email { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public override string ToString()
        {
            return $"{Name} {Password}";
        }
    }
    
}
