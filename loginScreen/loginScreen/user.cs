using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginScreen
{
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserType  { get; set; }

        

        public User(string name, string password, string type)
        {
            this.Name = name;
            this.Password = password;
            this.UserType = type;
        }
        bool checkPassword(string password)
        {
            if (password == this.Password)
            {
                return true;
            }
            return false;
        }
    }
}
