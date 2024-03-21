using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        bool notNumber = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                if(e.KeyCode < Keys.NumPad0 || e.KeyCode>Keys.NumPad9)
                    if(e.KeyCode!=Keys.Back)
                    {
                        notNumber = true;
                        textBox2.Text += e.KeyCode.ToString();
                    }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notNumber == true)
                e.Handled = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            notNumber = false;
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("Am apasat F1!");
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar >= '0' && e.KeyChar <= '9' ||
                e.KeyChar == (char)8 || e.KeyChar == '.')
                e.Handled = false;
            else
                e.Handled = true;*/
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvare");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Afisare");
        }
    }
}
