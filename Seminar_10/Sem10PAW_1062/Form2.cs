using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sem10PAW_1062
{
    public partial class Form2 : Form
    {
        string connString;
        public Form2()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = studenti.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;

                comanda.CommandText = "SELECT MAX(cod) FROM studenti";
                int cod = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO studenti VALUES(?,?,?,?)";
                comanda.Parameters.Add("cod", OleDbType.Integer).Value = cod + 1;
                comanda.Parameters.Add("nume", OleDbType.Char, 30).Value = tbNume.Text;
                comanda.Parameters.Add("forma", OleDbType.Char, 2).Value = cbForma.Text;
                comanda.Parameters.Add("medie", OleDbType.Double).Value = Convert.ToDouble(tbMedia.Text);
                comanda.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbNume.Clear();
                cbForma.Text = "";
                tbMedia.Clear();
            }
        }
    }
}
