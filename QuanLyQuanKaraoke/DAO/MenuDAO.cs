using System;
using QuanLyQuanKaraoke.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        //Hàm để các class bên ngoài truy xuất vài class MenuDAO
        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuDAO();
                }
                else
                {
                    ;
                }
                return MenuDAO.instance;
            }
            private set
            {
                MenuDAO.instance = value;
            }
        }
        private MenuDAO()
        {
            ;
        }
        //Hiển thị danh sách Menu
        public List<Menu> GetListMenuByRoom(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.nameFood, bi.countFood, f.price, f.price*bi.countFood AS totalPrice FROM  BillInfo AS bi, Bill AS b, Food AS f WHERE b.stat =0 and bi.idBill = b.idBill AND bi.idFood = f.idFood AND b.idRoom = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
