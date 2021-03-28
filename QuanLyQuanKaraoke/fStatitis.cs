using QuanLyQuanKaraoke.DAO;
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
    public partial class fStatitis : Form
    {
        public fStatitis()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
        }
        #region Methods
        //Set ngày bắt đầu và kết thúc cho datetimepicker
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);

        }
        //Hiện bill dựa trên time của datetimepicker
        void LoadListBillByDate(DateTime timeIn,DateTime timeOut)
        {
            dtgvStatitis.DataSource=BillDAO.Instance.GetBillListByDate(timeIn, timeOut);
        }
        #endregion
        #region Events
        //Hiện thông tin thống kê
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
        }
        //Đưa đến đầu trang
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("OK");
            txbNumberPage.Text = "1";
        }
        //Đưa đến cuối trang
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("OK");
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpFromDate.Value, dtpToDate.Value);
            //MessageBox.Show("OK");
            int lastPage = sumRecord / 10;
            //MessageBox.Show("OK");
            if (sumRecord % 10 != 0)
            {
                lastPage++;
            }
            else
            {
                ;
            } 
            //MessageBox.Show("OK");
            txbNumberPage.Text = lastPage.ToString();
        }
        //Button Previos : hiện trang trước 
        private void btnBefore_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbNumberPage.Text);
            if (page > 1)
            {
                page--;
            }
            else
            {
                ;
            } 
            txbNumberPage.Text = page.ToString();
        }
        //Button Next : hiện trang sau 
        private void btnAfter_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbNumberPage.Text);
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpFromDate.Value, dtpToDate.Value);
            if (page < sumRecord)
            {
                page++;
            }
            else
            {
                ;
            }  
            txbNumberPage.Text = page.ToString();
        }
        //Text box thay đổi trang khi click các button
        private void txbNumberPage_TextChanged(object sender, EventArgs e)
        {
            dtgvStatitis.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpFromDate.Value, dtpToDate.Value, Convert.ToInt32(txbNumberPage.Text));
        }
        #endregion
    }
}
