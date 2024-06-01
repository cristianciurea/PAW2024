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

namespace ListaTari1063
{
    public partial class ListaTari1063: UserControl
    {
        public ListaTari1063()
        {
            InitializeComponent();

            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = bd1063.accdb";
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM tari", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "tari");
            DataTable tabela = ds.Tables["tari"];
            comboBox1.DataSource = tabela;
            comboBox1.DisplayMember = "Denumire";
        }
    }
}
