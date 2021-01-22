using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea6_Menu
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String valName = nombre.Text;
            String valLastName = apellidos.Text;

            MessageBox.Show("Hola" + " " + valName + " " + valLastName + "," + " " + "tus datos fueron guardados con exito.",
            "Información Importante");

            this.LimpiarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LimpiarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarDatos()
        {
            codigoCliente.Clear();
            nombre.Clear();
            apellidos.Clear();
            telefono.Clear();
        }

    }
}
