using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DTO
{
    public class Room
    {
        public Room(int id, string name, string status,int price)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
            this.Price = price;
        }

        public Room(DataRow row)
        {
            this.ID = (int)row["idRoom"];
            this.Name = row["nameRoom"].ToString();
            this.Status = row["stat"].ToString();
            this.Price = (int)row["price"];
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

        private string status;

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
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

        private int iD;

        public int ID
        {
            get
            {
                return iD;
            }
            set
            {
                iD = value;
            }
        }
    }
}
