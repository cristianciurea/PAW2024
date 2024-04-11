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

namespace Sem8PAW_1062
{
    public partial class Form1 : Form
    {
        List<Student> listaStud = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            incarcaDate();
            listView1.Columns.Add("Situatie");
        }

        public void incarcaDate()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while((linie = sr.ReadLine())!=null)
            {
                int nrMat = Convert.ToInt32(linie.Split(';')[0]);
                string nume = linie.Split(';')[1];
                float medie = (float)Convert.ToDouble(linie.Split(';')[2]);
                int anStudiu = Convert.ToInt32(linie.Split(';')[3]);
                string facultate = linie.Split(';')[4];
                Student s = new Student(nrMat, nume, medie, anStudiu, facultate);
                listaStud.Add(s);
            }
            sr.Close();
            MessageBox.Show("Date incarcate!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Student s in listaStud)
            {
                ListViewItem itm = new ListViewItem(s.nrMatricol.ToString());
                itm.SubItems.Add(s.nume);
                itm.SubItems.Add(s.medie.ToString());
                itm.SubItems.Add(s.anStudiu.ToString());
                itm.SubItems.Add(s.facultate);
                if (s.medie >= 5)
                    itm.SubItems.Add("promovat");
                else
                    itm.SubItems.Add("nepromovat");
                listView1.Items.Add(itm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                {
                    int nrMat = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaStud.Count; i++)
                        if (nrMat == listaStud[i].nrMatricol)
                            listaStud.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                {
                    int nrMat = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaStud.Count; i++)
                        if (nrMat == listaStud[i].nrMatricol)
                            listaStud.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaStud);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            foreach(Student s in listaStud)
            {
                sw.Write(s.nrMatricol);
                sw.Write(";");
                sw.Write(s.nume);
                sw.Write(";");
                sw.Write(s.medie);
                sw.Write(";");
                sw.Write(s.anStudiu);
                sw.Write(";");
                sw.Write(s.facultate);
                sw.WriteLine();
            }
            sw.Close();
            listView1.Items.Clear();
            MessageBox.Show("Date salvate!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            TreeNode parinte = new TreeNode("Studenti");
            treeView1.Nodes.Add(parinte);
            foreach(Student s in listaStud)
            {
                TreeNode copil = new TreeNode(s.nrMatricol + "-" + s.nume 
                    + "-" + s.medie + "-" + s.anStudiu + "-" + s.facultate);
                parinte.Nodes.Add(copil);
            }
            treeView1.ExpandAll();
        }
    }
}
