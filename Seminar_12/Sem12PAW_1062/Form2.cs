using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem12PAW_1062
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            login20241.ConnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = database.accdb";
        }
    }
}
