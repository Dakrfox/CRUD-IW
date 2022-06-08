using CRUD_IW.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_IW.Data
{
    internal class Clients
    {
        public static bool saveCLient(Client cli)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO clients_tb VALUES" +
                    "('"+ cli.Document +"','"+cli.Names+"','"+cli.Lastnames+"',"+cli.Age+",'"+cli.Sex+"','"+cli.Address+"', DEFAULT)";
                SqlCommand command = new SqlCommand(sql, con.connectTo());
                if (command.ExecuteNonQuery() == 1)
                {
                    con.disconnectTo();
                    return true;
                }
                else
                {
                    con.disconnectTo();
                    return false;
                }
                
                
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static DataTable showList()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM clients_tb;";
                SqlCommand command = new SqlCommand(sql, con.connectTo());
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader(CommandBehavior.CloseConnection));
                con.disconnectTo();
                return dt;


            }
            catch (Exception)
            {

                return null;
            }
        }

        public static Client cli_query(string document)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM clients_tb WHERE client_cc='"+document+"';";
                SqlCommand command = new SqlCommand(sql, con.connectTo());

                SqlDataReader dr = command.ExecuteReader();
                Client cli  = new Client(); 
                if (dr.Read())
                {
                    cli.Document = dr["client_cc"].ToString();
                    cli.Names = dr["client_name"].ToString();
                    cli.Lastnames = dr["client_lastname"].ToString();
                    cli.Age = Int32.Parse(dr["client_age"].ToString());
                    cli.Sex = dr["client_sex"].ToString();
                    cli.Address = dr["client_address"].ToString();
                    return cli;
                }
                else
                {
                    return null;
                }
                con.disconnectTo();
                


            }
            catch (Exception)
            {

                return null;
            }
        }

        public static bool updateCLient(Client cli)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE clients_tb SET client_name='" +cli.Names+ "' ,client_lastname='" + cli.Lastnames + "' ,client_age='"+cli.Age + "' ,client_sex='" + cli.Sex  + "' , client_address='"+ cli.Address +"'   where client_cc='" + cli.Document +"';" ;
                   
                SqlCommand command = new SqlCommand(sql, con.connectTo());
                if (command.ExecuteNonQuery() == 1)
                {
                    con.disconnectTo();
                    return true;
                }
                else
                {
                    con.disconnectTo();
                    return false;
                }


            }
            catch (Exception)
            {

                return false;
            }
        }


        public static bool deleteCLient(string document)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM clients_tb where client_cc='" + document + "';";

                SqlCommand command = new SqlCommand(sql, con.connectTo());
                if (command.ExecuteNonQuery() == 1)
                {
                    con.disconnectTo();
                    return true;
                }
                else
                {
                    con.disconnectTo();
                    return false;
                }


            }
            catch (Exception)
            {

                return false;
            }
        }

        public static DataTable queryClientOver25()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM clients_tb WHERE client_age>=25;";
                SqlCommand command = new SqlCommand(sql, con.connectTo());
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader(CommandBehavior.CloseConnection));
                con.disconnectTo();
                return dt;

           
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static DataTable orderBySex(String Sex)
        {
            if (Sex=="")
            {
                return null;
            }
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM clients_tb WHERE client_sex='"+Sex+"'";
                SqlCommand command = new SqlCommand(sql, con.connectTo());
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader(CommandBehavior.CloseConnection));
                con.disconnectTo();
                return dt;


            }
            catch (Exception)
            {
                return null;
            }
        }



    }
}
