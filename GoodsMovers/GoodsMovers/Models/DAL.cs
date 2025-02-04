using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace GoodsMovers.Models
{
    public class DAL
    {
        public ConnectionState st = ConnectionState.Closed;

        //======================For connecting to database=========================================================
        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=SWAPNIL\SQLEXPRESS;Initial Catalog=GoodsMovers;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            return con;
        }


        //======================================GetDataTable======================================================
        public DataTable GetDataTable(string query)
        {
            SqlConnection con = GetConnection();

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;

            DataTable dt = new DataTable();
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            con.Close();

            return dt;
        }

        //
        //
        //======================================GetExecuteScaler======================================================
        public Object GetExecuteScaler(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.Connection.Open();

            object value = cmd.ExecuteScalar();

            cmd.Connection.Close();

            return value;
        }

        //======================================GetExecuteNonQuery======================================================
        public int GetExecuteNonQuery(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.Connection.Open();

            int returnvalue = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return returnvalue;
        }
        //=======================================GetSqlDataReader=====================================================================
        public SqlDataReader GetSqlDataReader(string query)
        {
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.Connection.Open();

            SqlDataReader r = cmd.ExecuteReader();
            return r;

            con.Close();
        }
    }
}