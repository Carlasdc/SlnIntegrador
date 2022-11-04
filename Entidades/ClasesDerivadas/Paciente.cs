using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Ayudantes;
using Entidades.ClaseBase;
namespace Entidades.ClasesDerivadas
{
    public class Paciente:Individuo
    {
        public int NroHistoriaClinica { get; set; }
        public DateTime FechaNacimiento{ get; set; }
        public int Edad 
        { get
            {
                return UtilidadesFecha.CalcularEdad(FechaNacimiento);
            } 
        }
        public Paciente(int iD, string nombre, string apellido, string domicilio, string telefono, string email, int nroHistoriaClinica, DateTime fechaNacimiento) : base(iD, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
            FechaNacimiento = fechaNacimiento;
        }

    

    }
}
