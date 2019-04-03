using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using BELayer;

namespace DALLayer
{
    public class DAL
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlConnection getconn()
        {
            string str = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            return con;
        }
        public int Insert(student stu)
        {
            int flag = 0;
            using (con = getconn())
            {
                using (cmd = new SqlCommand("insert into Deprtment(id,name,domain_area,no_of_emp,location)values(@id,@name,@domain_area,@no_of_emp,@location)", con)) ;
                cmd.Parameters.AddWithValue("@id", stu.id);
                cmd.Parameters.AddWithValue("@name", stu.name);
                cmd.Parameters.AddWithValue("@domain_area", stu.domain_area);
                cmd.Parameters.AddWithValue("@no_of_emp", stu.no_of_emp);
                cmd.Parameters.AddWithValue("@location", stu.location);
                con.Open();
                flag = cmd.ExecuteNonQuery();
                con.Close();
                Console.Write("Data Inserted");
            }
            return flag;
        }

    }

}

   
