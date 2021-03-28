using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DTO
{
    class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status,int foodPrice,string numberTimes, float totalPrice)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.FoodPrice = foodPrice;
            this.NumberTimes = numberTimes;
            this.TotalPrice = totalPrice;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["idBill"];
            var dateCheckInTemp = row["timeCheckIn"];
            if(dateCheckInTemp.ToString() != "")
            {
                this.dateCheckIn = (DateTime?)dateCheckInTemp;
            }
            var dateCheckOutTemp = row["timeCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.dateCheckOut = (DateTime?)dateCheckOutTemp;
            }
            this.Status = (int)row["stat"];
            this.FoodPrice = (int)row["foodPrice"];
            this.NumberTimes = row["numberTimes"].ToString();
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }
        private float totalPrice;
        public float TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
            }
        }   
        private string numberTimes;
        public string NumberTimes
        {
            get
            {
                return numberTimes;
            }
            set
            {
                numberTimes = value;
            }
        }
        private int foodPrice;
        public int FoodPrice
        {
            get
            {
                return foodPrice;
            }
            set
            {
                foodPrice = value;
            }
        }
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get
            {
                return dateCheckIn;
            }
            set
            {
                dateCheckIn = value;
            }
        }
        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get
            {
                return dateCheckOut;
            }
            set
            {
                dateCheckOut = value;
            }
        }
        private int status;
        public int Status
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
    }
}
