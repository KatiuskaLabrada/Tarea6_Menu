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
    public partial class ListarUsuarios : Form
    {
        public ListarUsuarios()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row0 = { "66173", "Katiuska", "Labrada",
            "829-634-7588"};
            string[] row1 = { "66174", "Carmen", "Perez",
            "829-414-9301"};
            string[] row2 = { "66175", "Jose", "Mora",
            "829-266-5096"};
            string[] row3 = { "66176", "Tommy", "Gonzalez",
            "809-589-6963"};
            string[] row4 = { "66177", "Nicolas", "Hernandez",
            "809-874-2563"};
            string[] row5 = { "66178", "Karla", "Martinez",
            "809-723-9654"};

            dataGridView1.Rows.Add(row0);
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
            dataGridView1.Rows.Add(row4);
            dataGridView1.Rows.Add(row5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
