//using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLoginDB.Model
{
    public class LoginList
    {
        private readonly List<Loginfo> loginfos = new List<Loginfo>();

        public IEnumerable<Loginfo> GetLoginfosForUser(string username)
        {
            return loginfos.Where(x => x.Username == username);
        }
        public IEnumerable<Loginfo> GetAllUser()
        {
            return loginfos;
        }
        public void AddLoginfo(Loginfo loginfo)
        {
            loginfos.Add(loginfo);
        }
    }
}
