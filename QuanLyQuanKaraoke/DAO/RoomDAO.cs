using QuanLyQuanKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;
        //Hàm để các class bên ngoài truy xuất vài class RoomDAO
        public static RoomDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomDAO();
                }
                else
                {
                    ;
                }
                return RoomDAO.instance;
            }
            private set
            {
                RoomDAO.instance = value;
            }
        }
        private RoomDAO()
        {
            ;
        }
        //Lấy danh sách room từ db
        public List<Room> GetListRoom()
        {
            List<Room> list = new List<Room>();
            string query = "select * from Room ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                list.Add(new Room(item));
            }
            return list;
        }
        //Tìm phòng dựa trên tên phòng
        public List<Room> SearchRoomByName(string name)
        {
            List<Room> list = new List<Room>();

            string query = string.Format("SELECT * FROM Room WHERE dbo.fuConvertToUnsign1(nameRoom) LIKE N'%' +dbo.fuConvertToUnsign1(N'{0}')+'%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                list.Add(room);
            }

            return list;
        }
        //Sửa room trong db
        public bool UpdateRoom(int id,string name, string status, int price)
        {
            string query = string.Format("UPDATE Room SET nameRoom = N'{1}', stat = N'{2}',price = {3} WHERE idRoom ={0}", id, name, status, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //Xóa room trong db
        public bool DeleteRoom(int id)
        {
            string query = string.Format("Delete Account where userName = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //Thêm room trong db
        public bool InsertRoom(string name, string status, int price)
        {
            string query = string.Format("insert into Room values  ( N'{0}', N'{1}', {2})", name, status, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
