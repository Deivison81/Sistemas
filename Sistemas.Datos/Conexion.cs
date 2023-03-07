using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistemas.Datos
{
    class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "dbsistema";
            this.Servidor = "TECNODEX";
            this.Usuario = "tecno";
            this.Clave = "tecno";
            this.Seguridad = true;
        }
        public SqlConnection CrearConexion() 
        {
            SqlConnection cadena = new SqlConnection(); 
            {
                try
                {
                    cadena.ConnectionString = "Server=" + this.Servidor + "; DataBase =" + this.Base + ";";
                    if (this.Seguridad)
                    {
                        cadena.ConnectionString = cadena.ConnectionString + "Integrated Security= SSPI";
                    }
                    else 
                    {
                        cadena.ConnectionString = cadena.ConnectionString + "User Id" + this.Usuario + ";Password=" + this.Clave;
                    }
                }
                catch (Exception ex) 
                {
                    cadena = null;
                    throw ex;
                }
                return cadena;
            }

        }
        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();

            }
            return con;
        }
    }
}
