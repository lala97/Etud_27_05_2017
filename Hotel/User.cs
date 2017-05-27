using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class User
    {
        public string id { get; set; }

        public string name { get; set; }
        public string surname { get; set; }
        public User(string id,string name,string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
    }
}
