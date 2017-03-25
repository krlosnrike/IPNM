using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Datos.Utilitarios.DataBase;
using System.Data;


namespace Datos
{
    public class hola
    {

        public string holaMundo(string a)
        {

            Connection con = new Connection();

            MySqlConnection cn = con.Connect();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "HolaMundo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("parametro1", MySqlDbType.VarChar).Value = a;

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);


            try
            {
                cn.Open();
                da.Fill(dt);
                string result = "";
                foreach (DataRow drow in dt.AsEnumerable().ToList())
                {
                    result= drow[0].ToString();
                }
                return result;
            }
            catch
            {

                return "";
            }
            finally
            {
                da.Dispose();
                cn.Dispose();
                
            }
            
            
        }
    }
}
