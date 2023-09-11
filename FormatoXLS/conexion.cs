using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FormatoXLS
{
    internal class conexion
    {
        public SqlConnection cnn = new SqlConnection(@"Server=DESKTOP-EUB75BK;Database=Capacitacion;Integrated Security=True");
    }
}
