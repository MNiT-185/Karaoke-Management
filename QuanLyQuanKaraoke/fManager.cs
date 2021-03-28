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
    public partial class fManager : Form
    {
        #region Variables
        //Account hiện tại
        private Account loginAccount;
        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }
            set
            {
                loginAccount = value;
                ChangeAccount(loginAccount.Type);
            }
        }
        #endregion
        public fManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            lbDisplayName.Text = "Hi " + LoginAccount.DisplayName;
        }
        #region Methods
        //Hiện lại tên hiển thị ng dùng khi update
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            lbDisplayName.Text = "Hi " + e.Acc.DisplayName;
        }
        //Phân quyền cho Admin và Nhân Viên
        void ChangeAccount(int type)
        {
            btnAdmin.Enabled = type == 1;

        }
        #endregion
        #region Events
        //butoon Admin(Admin quản lý csdl)
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fAdminManager f = new fAdminManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        //button Thông tin (Thay đổi thông tin ng dùng)
        private void btnProfile_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }
        //button App(Ng dùng quản lý việc đặt phòng , trả phòng , thanh toán)
        private void btnManager_Click(object sender, EventArgs e)
        {
            fRoomManager f = new fRoomManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        //Button LogOut
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
