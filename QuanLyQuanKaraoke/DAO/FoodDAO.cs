using QuanLyQuanKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        //Hàm để các class bên ngoài truy xuất vài class FoodDAO
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDAO();
                }
                else
                {
                    ;
                }
                return FoodDAO.instance;
            }
            private set
            {
                FoodDAO.instance = value;
            }
        }
        private FoodDAO()
        {
            ;
        }
        //Lấy danh sách food từ db
        public List<Food> GetListFood(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food where idFoodCategory=" + id;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                list.Add(new Food(item));
            }
            return list;
        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        //Thêm food vào db
        public bool InsertFood(string name, int id, float price)
        {
            string query = string.Format("insert into Food values  ( N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //Sửa food trong db
        public bool UpdateFood(int idFood, string name, int id, float price)
        {
            string query = string.Format("UPDATE Food SET nameFood = N'{0}', idFoodCategory = {1}, price = {2} WHERE idFood = {3}", name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //Xóa food trong db
        public bool DeleteFood(int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("Delete Food where idFood = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //tìm food trong db dựa trên tên food
        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("SELECT * FROM Food WHERE dbo.fuConvertToUnsign1(nameFood) LIKE N'%' +dbo.fuConvertToUnsign1(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
    }
}
