using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem3PAW_1063_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                char sex = Convert.ToChar(cbSex.Text);
                string nume = tbNume.Text;
                int varsta = Convert.ToInt32(tbVarsta.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                cbSex.Text = "";
                tbNume.Clear();
                tbVarsta.Clear();
                tbNote.Clear();
            }
        }
    }
}
