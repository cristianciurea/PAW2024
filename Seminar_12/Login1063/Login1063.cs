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

namespace Login1063
{
    public partial class Login1063: UserControl
    {
        private string connString;

        public string ConnString
        {
            set
            {
                if (value != null)
                    connString = value;
            }
        }

        public Login1063()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            try
            {
                conexiune.Open();
                comanda.CommandText = "SELECT COUNT(*) FROM utilizatori WHERE username='" + tbUser.Text + "' AND password='" + tbPass.Text + "'";
                int nr = Convert.ToInt32(comanda.ExecuteScalar());
                if (nr > 0)
                    MessageBox.Show(tbUser.Text + " s-a autentificat!");
                else
                    MessageBox.Show("Utilizator inexistent sau parola gresita!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }
    }
}
