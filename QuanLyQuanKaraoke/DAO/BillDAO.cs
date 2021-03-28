using QuanLyQuanKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.DAO
{
    public class BillDAO //Lay ra Bill tu ID table
    {
        private static BillDAO instance;
        //hàm để các class ở ngoài truy cập vào BillDAO
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                else
                {
                    ;
                }
                return BillDAO.instance;
            }
            private set
            {
                BillDAO.instance = value;
            }
        }
        private BillDAO()
        {
            ;
        }
        //Lấy Bill dựa trên idRoom
        public int GetBillIDByRoomID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select *from Bill where stat = 0 AND idRoom = " + id);
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID; //Thanh Cong
            }
            else
            {
                return -1;
            }
        }
        //Thêm Bill mới vào db
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idRoom", new object[] { id });
        }
        //Lấy idBill lớn nhất
        public int GetMax()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(idBill) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }
        //Thanh toán Bill stat= 1: đã thanh toán; stat=0: chưa thanh toán
        public void CheckOut(int id)
        {
            string query = "UPDATE Bill SET stat = 1 where idBill = " + id;
            DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy Bill dựa trên ngày checkin ,checkout
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        //Lấy Bill dựa trên ngày checkin ,checkout và số của trang
        public DataTable GetBillListByDateAndPage(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            return DataProvider.Instance.ExecuteQuery("exec GetListBillByDateAndPage @checkIn , @checkOut , @page", new object[] { checkIn, checkOut, pageNum });
        }
        //Lấy số trang dựa trên ngày
        public int GetNumBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec GetNumBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
    }
}
