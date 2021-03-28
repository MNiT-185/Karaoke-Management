using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DTO
{
    public class Menu
    {
        public Menu(string foodName,int countFood,int price,int totalPrice = 0)
        {
            this.FoodName = foodName;
            this.CountFood = countFood;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.FoodName = row["nameFood"].ToString();
            this.CountFood = (int)row["countFood"];
            this.Price = (int)row["price"];
            this.TotalPrice = (int)row["totalPrice"];
        }
        private int totalPrice;
        public int TotalPrice
        {
            get
            {
                return totalPrice;
            }
            private set
            {
                totalPrice = value;
            }
        }
        private int countFood;
        public int CountFood
        {
            get
            {
                return countFood;
            }
            private set
            {
                countFood = value;
            }
        }
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            private set
            {
                price = value;
            }
        }
        private string foodName;
        public string FoodName
        {
            get
            {
                return foodName;
            }
            private set
            {
                foodName = value;
            }
        }

    }
}
