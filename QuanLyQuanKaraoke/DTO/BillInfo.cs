using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DTO
{
    public class BillInfo
    {
        public BillInfo(int id,int idBill,int idFood,int countFood,int total)
        {
            this.ID = id;
            this.IDBill = idBill;
            this.IDFood = idFood;
            this.CountFood = countFood;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["idBillInfo"];
            this.IDBill = (int)row["idBill"];
            this.IDFood = (int)row["idFood"];
            this.CountFood = (int)row["countFood"];
        }
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }
        private int idBill;
        public int IDBill
        {
            get
            {
                return idBill;
            }
            private set
            {
                idBill = value;
            }
        }
        private int idFood;
        public int IDFood
        {
            get
            {
                return idFood;
            }
            private set
            {
                idFood = value;
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
    }
}
