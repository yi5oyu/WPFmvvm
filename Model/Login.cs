using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLoginDB.Model
{
    public class Login
    {
        private readonly LoginList loginList = new LoginList();
        public IEnumerable<Loginfo> GetLoginfosForUser(string username)
        {
            return loginList.GetLoginfosForUser(username);
        }
        public IEnumerable<Loginfo> GetAllUser()
        {
            return loginList.GetAllUser();
        }
        public void MakeLoginfo(Loginfo loginfo)
        {
            loginList.AddLoginfo(loginfo);
        }
        
    }
}
