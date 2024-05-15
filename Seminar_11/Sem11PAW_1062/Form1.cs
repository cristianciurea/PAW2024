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

namespace Sem11PAW_1062
{
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = masini.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM masini", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "masini");

            DataTable tabela = ds.Tables["masini"];

            foreach (DataColumn coloana in tabela.Columns)
                textBox1.Text += coloana.ColumnName + "   ";
            textBox1.Text += Environment.NewLine;

            foreach(DataRow linie in tabela.Rows)
            {
                foreach (object camp in linie.ItemArray)
                    textBox1.Text += camp + "   ";
                textBox1.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM masini", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "masini");

            DataTable tabela = ds.Tables["masini"];

            DataRow[] rows = tabela.Select("motorizare='BENZINA'", "marca");
            foreach (DataRow linie in rows)
                textBox1.Text += linie["marca"] + "   " + 
                    linie["motorizare"] + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM masini", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "masini");

            DataTable tabela = ds.Tables["masini"];

            DataView dv = new DataView(tabela);
            dv.Sort = "marca";
            dv.RowFilter = "motorizare='BENZINA'";
            foreach(DataRowView linie in dv)
                textBox1.Text += linie["marca"] + "   " +
                    linie["motorizare"] + Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM masini", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "masini");

            DataTable tabela = ds.Tables["masini"];

            adaptor.UpdateCommand = new OleDbCommand("UPDATE masini SET motorizare='"+comboBox1.Text+"'", conexiune);

            tabela.Rows[0].BeginEdit();
            tabela.Rows[0].EndEdit();

            adaptor.Update(tabela);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "CREATE PROCEDURE MasiniMotorizare AS SELECT * FROM masini WHERE motorizare=@motorizare";
                comanda.ExecuteNonQuery();
                MessageBox.Show("Procedura creata!");
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

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;

                comanda.CommandText = "MasiniMotorizare";
                comanda.CommandType = CommandType.StoredProcedure;
                comanda.Parameters.Add("@motorizare", OleDbType.Char, 20).Value = comboBox1.Text;
                OleDbDataReader reader = comanda.ExecuteReader();
                while(reader.Read())
                {
                    textBox1.Text += reader["marca"] + "   " 
                        + reader["motorizare"] + Environment.NewLine;
                }
                reader.Close();
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
