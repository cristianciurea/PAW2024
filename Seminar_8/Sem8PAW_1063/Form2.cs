using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem8PAW_1063
{
    public partial class Form2 : Form
    {
        List<Cladire> lista2;
        public Form2(List<Cladire> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                int nrEtaje = Convert.ToInt32(tbEtaje.Text);
                string adresa = tbAdresa.Text;
                float suprafata = (float)Convert.ToDouble(tbSuprafata.Text);
                Cladire cladire = new Cladire(cod, nrEtaje, adresa, suprafata);
                lista2.Add(cladire);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbEtaje.Clear();
                tbAdresa.Clear();
                tbSuprafata.Clear();
            }
        }
    }
}
