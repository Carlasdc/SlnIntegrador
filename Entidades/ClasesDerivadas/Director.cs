using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.ClaseBase;

namespace Entidades.ClasesDerivadas
{
    public class Director:Medico
    {
        public Director(int iD, string nombre, string apellido, string domicilio, string telefono, string email, string matricula, string especialidad, string postgrado) : base(iD, nombre, apellido, domicilio, telefono, email, matricula, especialidad)
        {
            Postgrado = postgrado;
        }

        public string Postgrado { get; set; }
    }
}
