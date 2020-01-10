using ProjectHiTech.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHiTech.Business
{
    public  class LoginUser
    {
        private string userName;
        private string password;

        public string Username { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public int CheckUserLogin(LoginUser loginuser)
        {
            return LoginDB.CheckUserLoginDB(loginuser);
        }
    }
}
