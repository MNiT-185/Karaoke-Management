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
    public partial class fRoomManager : Form
    {
        #region Variables
        public static int idRoomThanhToan = 0;
        public static DateTime timeIn;
        public static DateTime timeOut;
        public static int foodPrice;
        public static Room r;
        #endregion
        public fRoomManager()
        {
            InitializeComponent();
            timer1.Start();
            txbTime.Text = DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss tt");
            LoadRoom();
            LoadCategory();
        }
        #region Methods
        void LoadCategory()
        {
            cbbCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            cbbCategory.DisplayMember = "name";
        }
        void LoaFoodByCategory(int id)
        {
            cbbFood.DataSource = FoodDAO.Instance.GetListFood(id);
            cbbFood.DisplayMember = "name";
        }
        /*Phương thức tạo Phòng và load Phòng
         */ 
        void LoadRoom()
        {
            flpRoom.Controls.Clear();
            List<Room> roomList = RoomDAO.Instance.GetListRoom();

            foreach (Room item in roomList)
            {
                Button btn = new Button()
                {
                    Width = 100,
                    Height = 100
                };
                //btn
                btn.Click += btn_Click;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Text = item.Name + Environment.NewLine + Environment.NewLine + String.Format("{0:0,0 vnđ}", item.Price)+ Environment.NewLine+ Environment.NewLine + item.Status;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        {
                            btn.BackColor = Color.Aqua;
                            break;
                        }
                    default:
                        {
                            btn.BackColor = Color.Red;
                            break;
                        }
                }
                flpRoom.Controls.Add(btn);
            }
        }
        /*Phương thức để hiện bill lên ListView 
         */ 
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByRoom(id);
            int toTalPrice = 0;
            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.CountFood.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                toTalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            foodPrice = toTalPrice;
        }
        #endregion
        #region Events
        /*Button Thanh Toán
         * Nếu idRoom = -1 : Fail
         * Ngược lại timeOut bằng tg hiện tại
         * Show bảng Thanh Toán
         */
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = lsvBill.Tag as Room;
                int idRoom = (int)room.ID;
                //MessageBox.Show(BillDAO.Instance.GetBillIDByRoomID(idRoom).ToString());
                idRoomThanhToan = idRoom;
                if (idRoom == -1)
                {
                    ;
                }
                else
                {
                    timeOut = DateTime.Now;
                    fThanhToan f = new fThanhToan();
                    f.Show();
                    this.ShowBill(room.ID);
                }

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        /*Button Đặt Phòng
         * Sau khi click
         * Nếu phòng trống sẽ đổi status phòng thành có người
         * Ngược lại nếu phòng đã đc đặt nhưng do app hoặc users out ra đột xuất sẽ xét lại idBill 
         * nếu có idBill thì timeIn = time đã lưu trong db trước đó
         * Ngược lại : Fail
         * Xét idBill nếu idBill == -1 tạo idBill và use proc Book (update timeCheckIn)
         * Ngược lại : Fail
         */ 
        private void btnBookRoom_Click(object sender, EventArgs e)
        {

            Room room = lsvBill.Tag as Room;
            int idRoom = (int)room.ID;
            int idBill = BillDAO.Instance.GetBillIDByRoomID(room.ID);
            //MessageBox.Show(idBill.ToString());
            if (room.Status == "Trống")
            {
                string query = "UPDATE Room SET stat = N'Có Người' where idRoom = " + idRoom;
                DataProvider.Instance.ExecuteQuery(query);
                LoadRoom();
                //MessageBox.Show("OK");
            }
            else
            {
                //MessageBox.Show("Phòng đã được đặt");
                if (idBill != -1)
                {
                    timeIn = (DateTime)DataProvider.Instance.ExecuteScalar("select timeCheckIn from Bill where idBill=" + idBill);
                }
                else
                {
                    ;
                }
            }
            if (idBill == -1)
            {
                //MessageBox.Show("Chưa có bill");
                BillDAO.Instance.InsertBill(room.ID);
                idBill = BillDAO.Instance.GetBillIDByRoomID(room.ID);
                DataProvider.Instance.ExecuteNonQuery("exec book @idBill", new object[] { idBill });
                timeIn = (DateTime)DataProvider.Instance.ExecuteScalar("select timeCheckIn from Bill where idBill=" + idBill);
            }
            else
            {
                MessageBox.Show("Đã có bill");
            }
        }
        /*Button Trả Phòng
         * Sau khi click
         * Nếu status != trống sẽ update lại stat thành trống
         * Ngược lại : False
         */
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;
            r = room; //r là biến room dùng chung cho fThanhToan
            int idRoom = (int)room.ID;
            //MessageBox.Show(room.ID.ToString());
            if (room.Status != "Trống")
            {
                string query = "UPDATE Room SET stat = N'Trống' where idRoom = " + idRoom;
                DataProvider.Instance.ExecuteQuery(query);
                LoadRoom();
                //MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Phòng chưa được đặt");
            }

        }
        /*Button Phòng
         * Sự kiện click của từng phòng
         */
        void btn_Click(object sender, EventArgs e)
        {
            int roomID = ((sender as Button).Tag as Room).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(roomID);
        }
        /*Combobox Category
         */ 
        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 1;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            else
            {
                Category selected = cb.SelectedItem as Category;
                id = selected.ID;
                LoaFoodByCategory(id);
            }
        }
        /*Button Thêm
         * Xét status nếu có người và chưa có idBill thì tạo 1 bill mới và tạo thêm 1 billInfo mới
         * nếu có bill thì chỉ tạo thêm billInfo mới
         */
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;
            MessageBox.Show(room.ID.ToString());
            int idBill = BillDAO.Instance.GetBillIDByRoomID(room.ID);
            MessageBox.Show(idBill.ToString());
            int foodID = (cbbFood.SelectedItem as Food).IDFood;
            int count = (int)nmFoodCount.Value;
            string status = room.Status;
            if (status == "Có Người")
            {
                if (idBill == -1)
                {
                    MessageBox.Show("Chưa có bill");
                    BillDAO.Instance.InsertBill(room.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMax(), foodID, count);
                }
                else
                {
                    MessageBox.Show("Đã có bill");
                    BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
                }
                ShowBill(room.ID);
            }
            else
            {
                ;
            }
        }
        /*Timer tg hiện tại
         */ 
        private void timer1_Tick(object sender, EventArgs e)
        {
            txbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }
        #endregion
    }
}
