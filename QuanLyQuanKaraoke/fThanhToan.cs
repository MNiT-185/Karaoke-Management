using QuanLyQuanKaraoke.DAO;
using QuanLyQuanKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke
{
    public partial class fThanhToan : Form
    {
        public fThanhToan()
        {
            InitializeComponent();
            showRoom();
        }
        #region Methods
        //Hiện thông tin lên
        void showRoom()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            //Hiện tên phòng hiện tại
            int idRoom = fRoomManager.idRoomThanhToan;
            string query = "select nameRoom from Room where idRoom = " + idRoom;
            txbRoom.Text = (string)DataProvider.Instance.ExecuteScalar(query);
            // Hiện giờ thanh toán
            DateTime timeOutRoom = fRoomManager.timeOut;
            txbTimeOut.Text = timeOutRoom.ToString();
            int fp = fRoomManager.foodPrice;
            // Hiện giá thức ăn 
            int idBill = BillDAO.Instance.GetBillIDByRoomID(idRoom);
            int foodPrice = fRoomManager.foodPrice;
            FoodPrice(idBill, foodPrice);
            //MessageBox.Show("OK");
            txbFoodPrice.Text = fRoomManager.foodPrice.ToString("c", culture);
            // Hiện giá phòng
            int roomPrice = (int)DataProvider.Instance.ExecuteScalar("select price from Room where idRoom = " + idRoom);
            txbRoomPrice.Text = roomPrice.ToString("c", culture);
            //Hiện số giờ trong phòng
            DateTime timeInRoom = fRoomManager.timeIn;
            TimeSpan Time = timeOutRoom - timeInRoom;
            int hour = Time.Hours;
            int minute = Time.Minutes;
            int second = Time.Seconds;
            string time = hour.ToString() + minute.ToString() + second.ToString();
            //MessageBox.Show(time);
            //MessageBox.Show(idBill.ToString());
            NumberTime(idBill, time);
            txbNumber.Text = Time.ToString();
            //Hiện tổng tiền cần thanh toán
            float price = hour * roomPrice + minute * (roomPrice / 60) + second * (roomPrice / 3600) + fRoomManager.foodPrice;
            TotalPrice(idBill, price);
            txbTotal.Text = price.ToString("c", culture);
            //Save timeIn and time out to db
            DataProvider.Instance.ExecuteNonQuery("exec checkOut @idBill", new object[] { BillDAO.Instance.GetBillIDByRoomID(idRoom) });
        }
        //Đưa giá thức ăn vào db
        public void FoodPrice(int idBill, int foodPrice)
        {
            DataProvider.Instance.ExecuteNonQuery("update Bill set foodPrice = " + foodPrice + " where idBill= " + idBill);
        }
        //Đưa số giờ vào db
        public void NumberTime(int idBill, string numberTimes)
        {
            DataProvider.Instance.ExecuteNonQuery("update Bill set numberTimes = " + numberTimes + " where idBill = " + idBill);
        }
        //Đưa tổng tiền vào db
        public void TotalPrice(int idBill, float price)
        {
            DataProvider.Instance.ExecuteNonQuery("update Bill set totalPrice = " + price + " where idBill = " + idBill);
        }
        #endregion
        #region Events
        //button Thanh toán
        private void button1_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetBillIDByRoomID(fRoomManager.idRoomThanhToan);
            MessageBox.Show(idBill.ToString());
            if (idBill != -1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho phòng này " , "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(idBill);
                    }
                }
                catch
                {

                }
            }
            else
            {
                ;
            }
            this.Close();
        }
        #endregion
    }
}
