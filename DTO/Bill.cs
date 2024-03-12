using System;
using System.Collections.Generic;
using System.Data;

namespace btl_cafe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckout,  int status ,int discount = 0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckout;
            this.Discount = discount;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp != DBNull.Value && !string.IsNullOrWhiteSpace(dateCheckOutTemp.ToString()))
            {
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;

                this.Status = (int)row["status"];
                this.Discount = (int)row["discount"];


            }
            else
            {
                this.DateCheckOut = null; // Set DataCheckOut to null if it's DBNull or empty
            }
        }
        private int discount;
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
    }
}