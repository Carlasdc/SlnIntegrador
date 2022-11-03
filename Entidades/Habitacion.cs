using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitacion
    {
        public Habitacion(int iD, string numero, string estado)
        {
            Estado = estado;
            ID = iD;
            Numero = numero;
        }
        public int ID { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }
    }
}
