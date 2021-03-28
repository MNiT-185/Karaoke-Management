using QuanLyQuanKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        //Hàm để các class bên ngoài truy xuất vài class AccountDAO
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                else
                {
                    ;
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private AccountDAO()
        {
            ;
        }
        //Hàm kiểm tra đăng nhập
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
        //Sửa lại thông tin ở form AccountProfile
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, pass, newPass });
            return result > 0;
        }
        //Hàm lấy account từ db bằng username
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        //Lấy danh sách account từ db
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT userName, displayName, typeAccount FROM Account");
        }
        //Thêm account vào db
        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT into Account VALUES  ( N'{0}', N'{1}',1, {2})", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //Sửa account trong db
        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("UPDATE Account SET displayName = N'{1}', typeAccount = {2} WHERE userName = N'{0}'", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //Xóa Account trong db
        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where userName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //Đặt lại mật khẩu của user trong db
        public bool ResetPassword(string name)
        {
            string query = string.Format("update account set pass = N'1' where userName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
