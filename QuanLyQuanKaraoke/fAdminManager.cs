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
    public partial class fAdminManager : Form
    {
        public fAdminManager()
        {
            InitializeComponent();
        }
        #region Events
        //button Thống kê bill
        private void btnStatitis_Click(object sender, EventArgs e)
        {
            fStatitis f = new fStatitis();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        //Button truy cập vào quản lý phòng hát
        private void btnRoom_Click(object sender, EventArgs e)
        {
            fRoom f = new fRoom();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        //Button truy cập vào quản lý thức ăn và tài khoản
        private void btnFood_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        //Button Log out
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
