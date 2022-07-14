using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    class User_Account
    {
        public int AccountId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public User_Account()
        {

        }

        public User_Account(int accountId, string? username, string? password)
        {
            AccountId = accountId;
            Username = username;
            Password = password;
        }
    }
}
