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
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("categoria_buscar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }


        }
        public string Insertar(Categoria Obj) 
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try 
            {
                sqlcon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("categoria_insertar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puede ingresar el registro";
            }
            catch (Exception ex) 
            {
                throw ex;
            } finally 
            {

                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;

        }
        public string Actualizar(Categoria Obj) 
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("categoria_actualizar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.Idcategoria;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puede Actualizar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }
        public string Eliminar(int id) 
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("categoria_eliminar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;
                
                sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puede Eliminar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }
        public string Activar(int id) 
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("categoria_activar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;

                sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se ha  podido Activar  el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }
        public string Desativar(int id) 
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("categoria_desactivar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;

                sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se ha  podido Desactivar  el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }

    }
}
