using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs12paw
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            login1.ConnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = curs12paw.accdb";
            login1.Tabela = "useri";
        }
    }
}
