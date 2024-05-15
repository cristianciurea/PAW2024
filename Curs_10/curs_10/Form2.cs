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

namespace curs_11
{
    public partial class Form2 : Form
    {
        string connString;
        public Form2()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = masini.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;

                comanda.CommandText = "SELECT MAX(cod) FROM masini";
                int cod = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO masini VALUES(?,?,?,?,?)";
                comanda.Parameters.Add("cod", OleDbType.Integer).Value = cod + 1;
                comanda.Parameters.Add("marca", OleDbType.Char, 20).Value = tbMarca.Text;
                comanda.Parameters.Add("model", OleDbType.Char, 20).Value = tbModel.Text;
                comanda.Parameters.Add("motorizare", OleDbType.Char, 20).Value = cbMotorizare.Text;
                comanda.Parameters.Add("pret", OleDbType.Double).Value = Convert.ToDouble(tbPret.Text);
                comanda.ExecuteNonQuery();
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
    }
}
