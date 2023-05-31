using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4522_Project.Resources.Requese
{
    internal class User
    {
        public int Account { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(int account, string name, string email, string password) {
            Account = account;
            UserName = name;
            Email = email;
            Password = password;
        }

    }
}
