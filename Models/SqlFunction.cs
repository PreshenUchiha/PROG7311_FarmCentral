using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FarmerMarket.Models
{
    public class SqlFunction
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        string ConnString;

        public SqlFunction()
        {
            ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\presh\OneDrive\Documents\FarmCentralDB.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConnString);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }

        public DataTable getData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConnString);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(String Query)
        {
            int Cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            cmd.CommandText = Query;
            Cnt = cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;

        }
        /*Code Attribution:
         MyCodeSpace, 2022. Online Grocery Shop Management System Using ASP.Net C# and SQL Server. [video] Available at: <https://youtu.be/LzEecpaWfbs> [Accessed 14 June 2022].*/
    }
} 