using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioWindowsForm
{
    public partial class Form1 : Form
    {
        private Contenedor contenedor = new Contenedor();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = txtNombre.Text;
            String ape = txtApellido.Text;
            contenedor.Agregar(nom, ape);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grillaAlumnos.DataSource = null;
            grillaAlumnos.DataSource = contenedor.alumnos;
        }
    }
}
