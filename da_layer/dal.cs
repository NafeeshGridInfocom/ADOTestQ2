using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using be_layer;

namespace da_layer
{
 
    public class dal
    {
        string str = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;

        public void InsertDeprtment(ta t)
        {
            con = new SqlConnection(str);
            cmd = new SqlCommand("insert into ta(id,name) values(@id,@name)", con);
            cmd.Parameters.AddWithValue("@id", t.id);
            cmd.Parameters.AddWithValue("@name", t.name);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void Updateta(ta t1)
        {
            con = new SqlConnection(str);
            cmd = new SqlCommand("update ta set name=@name where id=@id", con);
            cmd.Parameters.AddWithValue("@id", t1.id);
            cmd.Parameters.AddWithValue("@name", t1.name);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Deleteta(ta t2)
        {
            con = new SqlConnection(str);
            cmd = new SqlCommand("delete ta where id=@id", con);
            cmd.Parameters.AddWithValue("@id", t2.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SearchRecord(ta t3)
        {
            ta t = new ta();
            con = new SqlConnection(str);
            cmd = new SqlCommand("Select * from ta where name = @name", con);
            cmd.Parameters.AddWithValue("@name", t3.name);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
           if(read.HasRows)
            {
                t.name = read["name"].ToString();
            }
            read.Close();
            con.Close();

        }
    }
    
}
