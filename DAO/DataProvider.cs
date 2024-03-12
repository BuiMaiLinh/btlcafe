using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_cafe.DAO
{
    public class DataProvider
    {
        private string connectstring = @" Data Source=LAPTOP-KKK4SLQV\SQLEXPRESS; Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        private object dtgvAccount;
        private string query;
        private object item;

        private static DataProvider instance;

        private DataProvider() { }

        public static DataProvider Instance
            {
            get 
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set { instance = value; }
        }
        

        public DataTable ExecuteQuery(string query, object[] parameter=null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectstring))
            {

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            if (parameter != null ) {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            
            adapter.Fill(data);

            connection.Close();
            }
            return data;

        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectstring))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;

        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectstring))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;

        }
    }
}
