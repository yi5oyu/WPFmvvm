using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLoginDB.Model
{
    public class Loginfo
    {
        public string UserID { get; }
        public string Username { get; }
        public string Password { get; }
        public string Usertype { get; }
        public Loginfo(string userID, string username, string password, string usertype)
        {
            UserID = userID;
            Username = username;
            Password = password;
            Usertype = usertype;
        }
    }
}
