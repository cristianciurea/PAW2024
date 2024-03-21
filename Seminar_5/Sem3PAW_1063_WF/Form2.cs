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
    public partial class Form2 : Form
    {
        public Form2(List<Student> lista)
        {
            InitializeComponent();
            foreach (Student s in lista)
                tbShow.Text += s.ToString() + Environment.NewLine;
        }
    }
}
