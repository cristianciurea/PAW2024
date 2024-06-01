using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem12PAW_1063
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            login10631.ConnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = bd1063.accdb";
        }
    }
}
