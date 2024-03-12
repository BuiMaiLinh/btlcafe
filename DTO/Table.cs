using System;
using System.Collections.Generic;
using System.Data;

namespace btl_cafe.DTO
{
    public class Table
    {
        // Thuộc tính và constructor
        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        // Constructor từ DataRow
        public Table(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"]);
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value;}
        }
    }
}
