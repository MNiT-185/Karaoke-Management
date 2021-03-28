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
    public partial class fRoom : Form
    {
        #region Variables
        BindingSource roomList = new BindingSource();
        #endregion
        public fRoom()
        {
            InitializeComponent();
            dtgvRoom.DataSource = roomList;
            LoadRoom();
            AddAccountBinding();
        }
        #region Methods
        // Trả về danh sách các phòng tìm đc
        List<Room> searchRoombyName(string name)
        {
            List<Room> listRoom = RoomDAO.Instance.SearchRoomByName(name);
            return listRoom;
        }
        //Hiện bảng phòng lấy từ db ra
        void LoadRoom()
        {
            roomList.DataSource = RoomDAO.Instance.GetListRoom();
        }
        //Binding đến các textbox
        void AddAccountBinding()
        {
            txbPriceRoom.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txbStatus.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "Status", true, DataSourceUpdateMode.Never));
            txbNameRoom.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbIdRoom.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        //Thêm phòng
        void AddRoom(string name, string status, int price)
        {
            if (RoomDAO.Instance.InsertRoom(name,status,price))
            {
                MessageBox.Show("Thêm danh mục thành công");
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại");
            }

            LoadRoom();
        }
        // Xóa phòng
        void DeteleRoom(int id)
        {
            if (RoomDAO.Instance.DeleteRoom(id))
            {
                MessageBox.Show("Xóa danh mục thành công");
            }
            else
            {
                MessageBox.Show("Xóa danh mục thất bại");
            }

            LoadRoom();
        }
        //Sửa phòng
        void EditRoom(int id, string name, string status, int price)
        {
            if (RoomDAO.Instance.UpdateRoom(id, name, status, price))
            {
                MessageBox.Show("Sửa danh mục thành công");
            }
            else
            {
                MessageBox.Show("Sửa danh mục thất bại");
            }

            LoadRoom();
        }
        #endregion
        #region Events
        //Button thêm phòng mới
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string name = txbNameRoom.Text;
            string status = txbStatus.Text;
            int price  = Convert.ToInt32(txbPriceRoom.Text);
            AddRoom(name, status, price);
        }
        //Button xóa phòng dựa trên id
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdRoom.Text);
            DeteleRoom(id);
        }
        //Button sửa đổi thông tin phòng ( tên , trang thái , giá)
        private void btnRepairRoom_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdRoom.Text);
            string name = txbNameRoom.Text;
            string status = txbStatus.Text;
            int price = Convert.ToInt32(txbPriceRoom.Text);
            EditRoom(id, name, status, price);
        }
        //Tìm kiếm phòng dựa trên Name
        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            roomList.DataSource = searchRoombyName(txbSearchRoom.Text);
        }
        //Hiện bảng phòng 
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadRoom();
        }
        #endregion
    }
}
