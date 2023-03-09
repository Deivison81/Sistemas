using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistemas.Datos;
using Sistemas.Entidades;

namespace Sistemas.Negocio
{
    public class NCategoria
    {
        public static DataTable Listar() 
        {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
            
        }

        public static DataTable Buscar(string valor)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(valor);
        }
        public static string Insertar(string Nombre, string Descripcion) 
        {
            DCategoria Datos = new DCategoria();
            Categoria Obj = new Categoria();
            Obj.Nombre = Nombre;
            Obj.Descripcion = Descripcion;

            return Datos.Insertar(Obj);
        }
        public static string Actualizar(int id, string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            Categoria Obj = new Categoria();
            Obj.Idcategoria = id;
            Obj.Nombre = Nombre;
            Obj.Descripcion = Descripcion;

            return Datos.Actualizar(Obj);
        }
        public static string Eliminar(int id)
        {
            DCategoria Datos = new DCategoria();
            
            return Datos.Eliminar(id);

        }
        public static string Activar(int id)
        {
            DCategoria Datos = new DCategoria();

            return Datos.Activar(id);
        }
        public static string Desactivar(int id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Desativar(id);
        }
    }
}
