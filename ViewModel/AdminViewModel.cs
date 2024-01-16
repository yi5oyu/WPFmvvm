using MVVMLoginDB.Command;
using MVVMLoginDB.Model;
using MVVMLoginDB.Service;
using MVVMLoginDB.Store;
//using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMLoginDB.ViewModel
{
    public class AdminViewModel : ViewModelBase
    {
        private readonly ObservableCollection<Loginfo> loginfos = new ObservableCollection<Loginfo>();
        private readonly Login login;

        public IEnumerable<Loginfo> Loginfos => loginfos;
        public ICommand SignUpCommand { get; }
        /*
        public ICommand DBConnect { get; }

        OracleConnection con;

        public void OraDBConnect()
        {
            string strcon = "data source=XE;User ID=C##YOUNG;Password=123";
            con = new OracleConnection(strcon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
         }
        public void UpdateData()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from LOG_DATA";
            OracleDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);  // 사용후 반환
            List<SignUpViewModel> log = new List<SignUpViewModel>();
            while (dr.Read())
            {
                log.Add(new SignUpViewModel()
                {
                    UserID = dr.GetString(dr.GetOrdinal("userID")),
                    Username = dr.GetString(dr.GetOrdinal("username")),
                    Password = dr.GetString(dr.GetOrdinal("password")),
                    Usertype = dr.GetString(dr.GetOrdinal("usertype"))
                });
            }

        }
        */
        public AdminViewModel(Login login, NavigationService userViewNavigationService)
        {
            /*
            this.OraDBConnect();
            this.UpdateData();
            */
            this.login = login;
            
            SignUpCommand = new NavigateCommand(userViewNavigationService);

        }
    }
}
