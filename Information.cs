using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace FacultyProject
{
    public class Information
    {
        public void GetInfo(string query, DataGridView dataInfo)
        {
            using (SqlConnection connection = new SqlConnection(Helper.CnnValue("ProjectCS")))
            {
                connection.Open();

                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                dataInfo.DataSource = dtbl;
            }
        }
    }
}
