﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.ClaseBase;
namespace Entidades.ClasesDerivadas
{
    public class Paciente:Individuo
    {
        public Paciente(int iD, string nombre, string apellido, string domicilio, string telefono, string email, int nroHistoriaClinica) : base(iD, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
        }

        public int NroHistoriaClinica { get; set; }
        
    }
}
