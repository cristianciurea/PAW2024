using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace curs12paw
{
    public partial class ListaTari : UserControl
    {
        public ListaTari()
        {
            InitializeComponent();

            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = curs12paw.accdb";
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM tari", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "tari");

            DataTable dt = ds.Tables["tari"];

            //DataTable dt = new DataTable();
            //dt.Columns.Add("ID");
            //dt.Columns.Add("Denumire");
            //dt.Rows.Add(1, "Albania");
            //dt.Rows.Add(2, "Belgia");
            //dt.Rows.Add(3, "China");
            //dt.Rows.Add(4, "Romania");
            //dt.Rows.Add(5, "Zimbabwe");

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Denumire";
        }
    }
}
