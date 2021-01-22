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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            seccionWebBrowser.ScriptErrorsSuppressed = true;
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioListarUsuario = new ListarUsuarios();
            formularioListarUsuario.Show();
        }

        private void irAPaginaWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seccionWebBrowser.Navigate("https://www.youtube.com/watch?v=QEaiUe1wKQE");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioCrearUsuario = new CrearUsuario();
            formularioCrearUsuario.Show();
        }
    }
}
