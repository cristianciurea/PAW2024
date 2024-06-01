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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            login1.ConnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = curs12paw.accdb";
            login1.Tabela = "useri";

            /* DataTable dt = new DataTable();
             dt.Columns.Add("utilizatori");
             dt.Rows.Add("Gigel");
             dt.Rows.Add("Maricica");

             listBox1.DataSource = dt;
             listBox1.DisplayMember = "utilizatori";*/

            listBox1.Items.Add("Gigel");
            listBox1.Items.Add("Maricica");


        }
    }
}
