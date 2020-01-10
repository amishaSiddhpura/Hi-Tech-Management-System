using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectHiTech.DataAccess;

namespace ProjectHiTech.Business
{
    public class MISmanager
    {
        private int userId;
        private string firstname;
        private string lastname;
        private string username;
        private string password;
        private int positionId;

        public int UserID { get => userId; set => userId = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string  Username { get => username; set => username = value; }
        public string Password{ get => password; set=>password=value; }
        public int Position{ get => positionId; set => positionId = value; }

        public DataTable ReadUserData()
        {
            return MISManagerDB.ReadUserDetails();
        }
        public bool SaveRecored(MISmanager manager)
        {
            return MISManagerDB.SaveRecoredDB(manager);
        }
        public bool UpdateRecord(MISmanager manager)
        {
            return MISManagerDB.UpdateRecordDB(manager);
        }
        public bool UpdatePassword(MISmanager manager)
        {
            return MISManagerDB.UpdatePassword(manager);
        }

        public bool DeleteRecord(MISmanager manager)
        {
            return MISManagerDB.DeleteRecordDB(manager);
        }
        public DataTable SearchRecord(MISmanager manager,int index)
        {
            return MISManagerDB.SearchRecordDB(manager,index);
        }
    }
}
