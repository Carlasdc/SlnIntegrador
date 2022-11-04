using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Negocio
{
    public static class AdmHabitacion
    {
        /// <summary>
        /// Se modificó a static. Tarea 6
        /// </summary>

        static List<Habitacion> habitaciones;
        public static List<Habitacion> Listar()
        {
            habitaciones = new List<Habitacion>();
            habitaciones.Add(new Habitacion( 0, "10" ,"ocupado"));
            habitaciones.Add(new Habitacion( 1, "22", "vacio" ));
            habitaciones.Add(new Habitacion( 2, "25", "ocupado" ));
            habitaciones.Add(new Habitacion( 3,  "12", "ocupado" ));
            habitaciones.Add(new Habitacion( 4, "15", "vacio" ));
            return habitaciones;
        }
        public static List<Habitacion> Listar(string Estado)
        {
            //TODO Falta programar el método Listar
            return null;
        }
        public static int Insertar(Habitacion habitaciones)
        {
            //TODO Falta programar el método Insertar
            return 0;
        }

        public static int Eliminar(int ID)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }
        public static List<Habitacion> TraerUno(string numero)
        {
            //TODO Falta programar el método TraerUno
            return null;
        }
    }
}
