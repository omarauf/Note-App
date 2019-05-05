using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class User
    {
        public bool Error { get; set; }
        public string Name { get; set; }
        public string Error_msg { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", " + "Email: " + Email + ", " + "Id: " + Id;
        }

    }
}
