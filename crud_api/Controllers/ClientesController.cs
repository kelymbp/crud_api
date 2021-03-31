using crud_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;

namespace crud_api.Controllers
{
    public class ClientesController : ApiController
    {
        //Identify database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ClientesDB.mdf;Integrated Security=True");

        //List all clients from database
        public DataTable Get()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from table1";
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //Add a client on database
        public void Post(string nome)
        {
            if(!string.IsNullOrEmpty(nome))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into table1 values('"+nome+"')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Delete a client from database
        public void Delete(string nome)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from table1 where nome='" + nome + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Update a client on database
        public void Put(string id, string nome)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update table1 set nome='" + nome + "' where id="+Convert.ToInt32(id)+"";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
