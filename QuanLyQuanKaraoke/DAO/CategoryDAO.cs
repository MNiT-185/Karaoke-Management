using QuanLyQuanKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        //Hàm để các class bên ngoài truy xuất vài class CategoryDAO
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                else
                {
                    ;
                }
                return CategoryDAO.instance;
            }
            private set
            {
                CategoryDAO.instance = value;
            }
        }
        private CategoryDAO()
        {
            ;
        }
        //Lấy danh sách danh mục trong db
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from FoodCategory";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in result.Rows)
            {
                list.Add(new Category(item));
            }
            return list;
        }
        //Lấy danh mục trong db bằng id
        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "select * from FoodCategory where idFoodCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }
        //Thêm danh mục trong db
        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT into FoodCategory VALUES  ( N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //Sửa danh mục trong db
        public bool UpdateCategory(int id,string name)
        {
            string query = string.Format("UPDATE FoodCategory SET nameCategory = N'{1}'WHERE idFoodCategory = {0}", id ,name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //Xóa danh mục trong db
        public bool DeleteCategory(int id)
        {
            string query = string.Format("Delete FoodCategory where idFoodCategory = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
