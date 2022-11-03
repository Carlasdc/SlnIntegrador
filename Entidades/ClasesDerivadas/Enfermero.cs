using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.ClaseBase;
namespace Entidades.ClasesDerivadas
{
    public class Enfermero:Individuo
    {
        public Enfermero(int iD, string nombre, string apellido, string domicilio, string telefono, string email, int cuil) : base(iD, nombre, apellido, domicilio, telefono, email)
        {
            Cuil = cuil;
        }

        public int Cuil { get; set; }
       
    }
}
