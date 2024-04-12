using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs7
{
    public partial class Form1 : Form
    {
        List<Student> listaStud = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            listaStud.Add(new Student(100, "Gigel", 8));
            listaStud.Add(new Student(200, "Maricica", 10));
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaStud);
            frm.MdiParent = this;
            frm.Show();
        }

        private void vizualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(listaStud);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void orizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(listaStud);
            frm.MdiParent = this;
            frm.Show();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5(listaStud);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
