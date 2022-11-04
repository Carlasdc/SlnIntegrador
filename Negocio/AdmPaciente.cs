using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.ClasesDerivadas;
namespace Negocio
{
    public static class AdmPaciente
    {
        /// <summary>
        /// Se modificó a static. Tarea 6
        /// </summary>
        /// 
        static List<Paciente> pacientes;

        public static List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente(0, "Juan", "Perez", "San Martin 50", "421653", "juan.perez@gmail.com", 123, new DateTime(2001,07,08)));
            pacientes.Add(new Paciente(1, "Maria", "Gonzales", "Belgrano 150", "422553", "maria.gonzales@gmail.com", 125, new DateTime(1995, 10, 08)));
            pacientes.Add(new Paciente(2, "Julia", "Paez", "Sarmiento 580", "435890", "julia.paez@gmail.com", 224, new DateTime(1991, 11, 11)));
            pacientes.Add(new Paciente(3, "Marta", "Martinez", "San Martin 500", "422222", "marta.martinez@gmail.com", 308, new DateTime(2006, 11, 02)));
            pacientes.Add(new Paciente(4, "Pedro", "Gomez", "San Juan 48", "421654", "pedro.gomez@gmail.com", 500, new DateTime(2011, 08, 07)));
            return pacientes;
        }

        public static int Insertar(Paciente pacientes)
        {
            //TODO Falta programar el método Insertar
            return 0;
        }
        public static int Eliminar(int ID)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }
        public static List<Paciente> TraerUno (string nroHistoriaClinica)
        {
            //TODO Falta programar el método TraerUno
            return null;
        }

    }
}
