using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DTO
{
    public class Food
    {
        public Food(int idFood,string name,int idCategory,int price)
        {
            this.IDFood = idFood;
            this.Name = name;
            this.IDCategory = idCategory;
            this.Price = price;
        }
        public Food(DataRow row)
        {
            this.IDFood = (int)row["idFood"];
            this.Name = (string)row["nameFood"];
            this.IDCategory = (int)row["idFoodCategory"];
            this.Price = (int)row["price"];
        }
        private int idFood;
        public int IDFood
        {
            get
            {
                return idFood;
            }
            set
            {
                idFood = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int idCategory;
        public int IDCategory
        {
            get
            {
                return idCategory;
            }
            set
            {
                idCategory = value;
            }
        }
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
