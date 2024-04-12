using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace curs7
{
    public partial class Form4 : Form
    {
        List<Student> lista2;
        public Form4(List<Student> lista)
        {
            InitializeComponent();
            listView1.Columns.Add("Situatie");
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Student s in lista2)
            {
                ListViewItem itm = new ListViewItem(s.cod.ToString());
                itm.SubItems.Add(s.nume);
                itm.SubItems.Add(s.nota.ToString());
                if (s.nota >= 5)
                    itm.SubItems.Add("promovat");
                else
                    itm.SubItems.Add("nepromovat");

                listView1.Items.Add(itm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while((linie = sr.ReadLine())!=null)
            {
                int cod = Convert.ToInt32(linie.Split(',')[0]);
                string nume = linie.Split(',')[1];
                int nota = Convert.ToInt32(linie.Split(',')[2]);
                Student s = new Student(cod, nume, nota);
                lista2.Add(s);
            }
            sr.Close();
            button1_Click(this, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("export.txt");
            foreach(Student s in lista2)
            {
                sw.Write(s.cod);
                sw.Write(",");
                sw.Write(s.nume);
                sw.Write(",");
                sw.Write(s.nota);
                sw.WriteLine();
            }
            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                    itm.Remove();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                    itm.Remove();
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.BackColor = Color.Red;
                textBox1.Text = e.Item.SubItems[0].Text;
                textBox2.Text = e.Item.SubItems[1].Text;
                textBox3.Text = e.Item.SubItems[2].Text;
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                    MessageBox.Show(itm.SubItems[0].Text);
        }
    }
}
