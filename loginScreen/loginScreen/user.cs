using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginScreen
{
    class user
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public Type UserType  { get; set; }

        public enum Type
        {
            Admin = 0,
            Worker = 1
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
