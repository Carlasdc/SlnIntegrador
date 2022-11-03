using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.ClasesDerivadas;
namespace Negocio
{
    public class AdmMedico
    {
        List<Medico> medicos;
        public List<Medico> Listar()
        {
            medicos = new List<Medico>();
            
            medicos.Add(new Medico(0, "Juan Ignacio", "Perez", "San Martin 50", "421653", "juani.perez@gmail.com", "001", "medico clinico"));
            medicos.Add(new Medico(1, "Maria Belen", "Gonzales", "Belgrano 150", "422553", "mariab.gonzales@gmail.com", "258", "medico clinico"));
            medicos.Add(new Medico(2, "Julia", "Paez", "Sarmiento 580", "435890", "julia.paez@gmail.com", "1520", "pediatra"));
            medicos.Add(new Medico(3, "Lucia", "Martinez", "San Martin 500", "422222", "lucia.martinez@gmail.com", "4592", "traumatologo"));
            medicos.Add(new Medico(4, "juan Pedro", "Garciarena", "San Juan 48", "421654", "juanpedro.garciarena@gmail.com", "4552", "traumatologo"));
            return medicos;
        }
        public List<Medico> Listar(string Especialidad)
        {
            //TODO Falta programar el método Listar
            return null;
        }

        public int Insertar(Medico medicos)
        {
            //TODO Falta programar el método Insertar
            return 0;
        }


        public int Eliminar(int ID)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }


    }
}