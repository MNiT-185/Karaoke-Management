using QuanLyQuanKaraoke.DAO;
using QuanLyQuanKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke
{
    public partial class fLogin : Form
    {
        public static string userNameP;
        public fLogin()
        {
            InitializeComponent();
        }
        #region Events
        //button Login
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = tbUsername.Text;
            userNameP = userName;
            string passWord = tbPassword.Text;
            if (AccountDAO.Instance.Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fManager f = new fManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
        //Button Exit
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Thông báo xác nhận khi đóng ứng dụng
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                ;
            }
        }
        #endregion
    }
}
