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
    public partial class Form3 : Form
    {
        public Form3(List<Student> lista)
        {
            InitializeComponent();
            foreach (Student s in lista)
                textBox1.Text +=
                    s.ToString() + Environment.NewLine;
        }
    }
}
