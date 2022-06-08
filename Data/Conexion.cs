using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_IW.Data
{
    internal class Conexion
    {
        SqlConnection con;
        public Conexion()
        {
            con = new SqlConnection("Server=DESKTOP-N2VKRB0; Database=clientes_db; integrated security=true");
            
        }
        public SqlConnection connectTo()
        {
            try
            {
                con.Open();
                return con;
            }catch(Exception e)
            {
                return null;
            }
            
        }
        public Boolean disconnectTo()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
