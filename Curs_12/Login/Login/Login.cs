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

namespace Login
{
    public partial class Login: UserControl
    {
        private string connString = null;
        private string tabela = null;

        public Login()
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
                comanda.CommandText = "SELECT COUNT(*) FROM " + tabela + " WHERE user='" + tbUtilizator.Text + "' AND pass='" + tbParola.Text + "'";
                int nr = Convert.ToInt32(comanda.ExecuteScalar());
                if (nr > 0)
                    MessageBox.Show(tbUtilizator.Text + " s-a logat!");
                else
                    MessageBox.Show("Utilizator neinregistrat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        public string ConnString
        {
            set
            {
                if (value != null)
                    connString = value;
            }
        }

        public string Tabela
        {
            set
            {
                if (value != null)
                    tabela = value;
            }
        }
    }
}
