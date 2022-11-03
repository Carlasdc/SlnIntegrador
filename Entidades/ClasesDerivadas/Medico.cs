using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.ClaseBase;
namespace Entidades.ClasesDerivadas
{
    public class Medico : Individuo
    {
        public Medico(int iD, string nombre, string apellido, string domicilio, string telefono, string email, string matricula, string especialidad) : base(iD, nombre, apellido, domicilio, telefono, email)
        {
            Matricula = matricula;
            Especialidad = especialidad;
        }

        public string Matricula { get; set; }
        public string Especialidad { get; set; }
    }
}