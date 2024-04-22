using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs_9
{
    public partial class Form3 : Form
    {
        string[] nume = { "Dorel", "Gigel", "Maricica" };
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Binding b = new Binding("Text", nume, "");
            comboBox1.DataBindings.Add(b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //comboBox2.DataSource = nume;

            listBox1.DataSource = nume;

            //dataGridView1.DataSource = nume;

            DataTable dt = new DataTable();
            dt.Columns.Add("Nume");
            foreach (string s in nume)
                dt.Rows.Add(s);

            dataGridView1.DataSource = dt;

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Nume";
        }
    }
}
