using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades.ClasesDerivadas;
using Entidades;
using Negocio;
namespace WindowsIntegrador
{
    public partial class Form1 : Form
    {
        //Modificado para parte 2

        //AdmMedico admMedico;
        //AdmPaciente admPaciente;
        //AdmHabitacion admHabitacion;

        public Form1()
        {
            InitializeComponent();
            //this.admMedico = new AdmMedico();
            //this.admPaciente = new AdmPaciente();
            //this.admHabitacion = new AdmHabitacion();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridInfo.DataSource = AdmMedico.Listar();

            foreach (Medico medico in AdmMedico.Listar("medico clinico"))
            {
                listMedicos.Items.Add("Nombre: " + medico.Nombre + " " + medico.Apellido);
            }
        }

        private void btnMostrarP_Click(object sender, EventArgs e)
        {
            gridInfo.DataSource = AdmPaciente.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            foreach (Habitacion habitacion in AdmHabitacion.Listar())
            {
                listHabitaciones.Items.Add("Número: " + habitacion.Numero + ", estado: " + habitacion.Estado);
            }
        }


    }
}
