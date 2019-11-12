using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;


namespace Controladores
{
    public class NPresentacion
    {
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);

        }
        public static string Editar(int idpresentacion, string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);

        }

        public static string Eliminar(int idpresentacion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;

            return Obj.Eliminar(Obj);

        }

        public static DataTable Mostrar()
        {
            return new DPresentacion().Mostar();

        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
