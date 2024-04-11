using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem8PAW_1062
{
    public partial class Form2 : Form
    {
        List<Student> lista2;
        public Form2(List<Student> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int nrMat = Convert.ToInt32(tbNrMatricol.Text);
                string nume = tbNume.Text;
                float medie = (float)Convert.ToDouble(tbMedie.Text);
                int anStudiu = Convert.ToInt32(cbAnStudiu.Text);
                string facultate = cbFacultate.Text;
                Student s = new Student(nrMat, nume, medie, anStudiu, facultate);
                lista2.Add(s);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbNrMatricol.Clear();
                tbMedie.Clear();
                tbNume.Clear();
                cbAnStudiu.Text = "";
                cbFacultate.Text = "";
            }
        }
    }
}
