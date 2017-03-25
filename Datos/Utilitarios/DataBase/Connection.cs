using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos.Utilitarios.DataBase
{
    public class Connection
    {

        public  MySqlConnection Connect()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=empleado; Uid=root; pwd=123456789;");

            return conectar;
        }

    }
}
