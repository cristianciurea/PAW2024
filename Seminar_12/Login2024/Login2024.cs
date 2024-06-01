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

namespace Login2024
{
    public partial class Login2024: UserControl
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

        public Login2024()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT COUNT(*) FROM utilizatori WHERE username='"+tbUser.Text+"' AND password='"+tbPass.Text+"'";
                int nr = Convert.ToInt32(comanda.ExecuteScalar());
                if (nr > 0)
                    MessageBox.Show(tbUser.Text + " s-a autentificat!");
                else
                    MessageBox.Show("Utilizator inexistent!");
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
