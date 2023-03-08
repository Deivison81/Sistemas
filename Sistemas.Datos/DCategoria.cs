using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistemas.Entidades;
using System.Data.SqlClient;

namespace Sistemas.Datos
{
    public class DCategoria
    {
        public DataTable Listar() 
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try 
            {
                sqlcon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("categoria_listar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        
        }

        public DataTable Buscar(string valor) 
        { 
        
        }
        public string insertar(Categoria Obj) 
        { 
            
        }
        public string Actualizar(Categoria Obj) 
        { 
        
        }
        public string Eliminar(int id) 
        { 
        
        }
        public string Activar(int id) 
        {
            
        }
        public string Desativar(int id) 
        { 
        
        }

    }
}
