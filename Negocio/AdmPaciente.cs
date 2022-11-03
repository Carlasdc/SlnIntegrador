using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.ClasesDerivadas;
namespace Negocio
{
    public class AdmPaciente
    {
        List<Paciente> pacientes;

        public List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente(0, "Juan", "Perez", "San Martin 50", "421653", "juan.perez@gmail.com", 123));
            pacientes.Add(new Paciente(1, "Maria", "Gonzales", "Belgrano 150", "422553", "maria.gonzales@gmail.com", 125));
            pacientes.Add(new Paciente(2, "Julia", "Paez", "Sarmiento 580", "435890", "julia.paez@gmail.com", 224));
            pacientes.Add(new Paciente(3, "Marta", "Martinez", "San Martin 500", "422222", "marta.martinez@gmail.com", 308));
            pacientes.Add(new Paciente(4, "Pedro", "Gomez", "San Juan 48", "421654", "pedro.gomez@gmail.com", 500));
            return pacientes;
        }

        public int Insertar(Paciente pacientes)
        {
            //TODO Falta programar el método Insertar
            return 0;
        }
        public int Eliminar(int ID)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }
        public List<Paciente> TraerUno (string nroHistoriaClinica)
        {
            //TODO Falta programar el método TraerUno
            return null;
        }

    }
}
