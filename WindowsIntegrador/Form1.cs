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
        public Form1()
        {
            InitializeComponent();
        }

        AdmMedico admMedico = new AdmMedico();
        AdmPaciente admPaciente = new AdmPaciente();
        AdmHabitacion admHabitacion = new AdmHabitacion();
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridInfo.DataSource = admMedico.Listar();  
        }

        private void btnMostrarP_Click(object sender, EventArgs e)
        {
            gridInfo.DataSource = admPaciente.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Medico medicos in admMedico.Listar())
            {
                listMedicos.Items.Add("Nombre: "+ medicos.Nombre + " " + medicos.Apellido);
            }
            foreach (Habitacion habitacion in admHabitacion.Listar())
            {
                listHabitaciones.Items.Add("Número: " + habitacion.Numero + ", estado: " + habitacion.Estado);
            }
        }


    }
}
