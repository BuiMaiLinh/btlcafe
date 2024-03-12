using btl_cafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace btl_cafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }



        public int GetUncheckBillIDByTableID(int id)
        {

            // return (int)DataProvider.Instance.ExecuteScalar(" "); 
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTable = " + id + " AND status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }



        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[]{id});
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int id, int discount)
        {
            string query = " update dbo.Bill set status = 1, " + " discount = " + discount + " WHERE id= " + id;
            //string query = " update dbo.Bill set status = 1 WHERE id= " + id;

            DataProvider.Instance.ExecuteNonQuery(query);

            //DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[]{id});
        }
    }
}