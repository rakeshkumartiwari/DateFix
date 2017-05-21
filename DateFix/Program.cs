using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DateFix
{
    class Program
    {
        static void Main(string[] args)
        {
            setTimeInline();


        }
        public static void setTimeParameter()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SqlExpress;Initial Catalog=Invoicing3;Integrated Security=true";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DateTime.Now.ToString("dd-MM-yyyy h:m:s");
            cmd.CommandText = "insert into DateTable (Date) values(@DOB)";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void setTimeInline()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SqlExpress;Initial Catalog=Invoicing3;Integrated Security=true";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into DateTable (join_date) values('" + DateTime.Now.ToString("dd-MM-yyyy h:m:s")+"')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
