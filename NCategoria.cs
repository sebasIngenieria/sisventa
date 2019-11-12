using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controladores
{
    public class NCategoria
    {
        public static string Insertar(string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);

        }
        public static string Editar(int idcategoria, string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);

        }

        public static string Eliminar(int idcategoria)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;

            return Obj.Eliminar(Obj);

        }

        public static DataTable Mostrar()
        {
            return new DCategoria().Mostar();

        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
