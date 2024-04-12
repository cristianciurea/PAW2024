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

namespace Sem8PAW_1063
{
    public partial class Form1 : Form
    {
        List<Cladire> listaCladiri = new List<Cladire>();
        public Form1()
        {
            InitializeComponent();
            incarcaDate();
        }

        public void incarcaDate()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while ((linie = sr.ReadLine())!=null)
            {
                string[] vect = linie.Split('|');
                int cod = Convert.ToInt32(vect[0]);
                int nrEtaje = Convert.ToInt32(vect[1]);
                string adresa = vect[2];
                float suprafata = (float)Convert.ToDouble(vect[3]);
                Cladire cladire = new Cladire(cod, nrEtaje, adresa, suprafata);
                listaCladiri.Add(cladire);
            }
            sr.Close();
            MessageBox.Show("Date incarcate!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listView1.Items.Clear();
            foreach(Cladire cladire in listaCladiri)
            {
                listBox1.Items.Add(cladire);
                //listBox1.Items.Add(cladire.codCladire + cladire.adresa);
                ListViewItem itm = new ListViewItem(cladire.codCladire.ToString());
                itm.SubItems.Add(cladire.nrEtaje.ToString());
                itm.SubItems.Add(cladire.adresa);
                itm.SubItems.Add(cladire.suprafata.ToString());
                listView1.Items.Add(itm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in listView1.Items)
                if(itm.Checked)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaCladiri.Count; i++)
                        if (cod == listaCladiri[i].codCladire)
                            listaCladiri.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaCladiri.Count; i++)
                        if (cod == listaCladiri[i].codCladire)
                            listaCladiri.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaCladiri);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            foreach(Cladire cladire in listaCladiri)
            {
                sw.Write(cladire.codCladire);
                sw.Write("|");
                sw.Write(cladire.nrEtaje);
                sw.Write("|");
                sw.Write(cladire.adresa);
                sw.Write("|");
                sw.Write(cladire.suprafata);
                sw.WriteLine();
            }
            sw.Close();
            listBox1.Items.Clear();
            listView1.Items.Clear();
            MessageBox.Show("Date salvate!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Cladiri");
            treeView1.Nodes.Add(parinte);
            foreach(Cladire cladire in listaCladiri)
            {
                TreeNode nod = new TreeNode();
                nod.Text = cladire.codCladire + "-" + cladire.nrEtaje;
                parinte.Nodes.Add(nod);
            }
            treeView1.ExpandAll();
        }
    }
}
