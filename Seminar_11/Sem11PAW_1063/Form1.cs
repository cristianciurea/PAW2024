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

namespace Sem11PAW_1063
{
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = bileteavion.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM bilete", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "bilete");

            DataTable tabela = ds.Tables["bilete"];

            dataGridView1.DataSource = tabela;

            foreach (DataColumn coloana in tabela.Columns)
                textBox1.Text += coloana.ColumnName + "   ";
            textBox1.Text += Environment.NewLine;

            foreach(DataRow linie in tabela.Rows)
            {
                foreach(object camp in linie.ItemArray)
                {
                    textBox1.Text += camp + "   ";
                }
                textBox1.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM bilete";
                OleDbDataReader reader = comanda.ExecuteReader();
                while(reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["idBilet"].ToString());
                    itm.SubItems.Add(reader["numeTitular"].ToString());
                    itm.SubItems.Add(reader["companieZbor"].ToString());
                    itm.SubItems.Add(reader["categorieBilet"].ToString());
                    itm.SubItems.Add(reader["pret"].ToString());
                    listView1.Items.Add(itm);
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

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM bilete", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "bilete");

            DataTable tabela = ds.Tables["bilete"];

            /*DataRow[] rows = tabela.Select("categorieBilet='" + comboBox1.Text + "'", "numeTitular");
            foreach (DataRow linie in rows)
                textBox1.Text += linie["numeTitular"] + "   " + linie["categorieBilet"] +
                    Environment.NewLine;*/

            DataView dv = new DataView(tabela);
            dv.RowFilter = "categorieBilet='" + comboBox1.Text + "'";
            dv.Sort = "numeTitular";
            foreach(DataRowView linie in dv)
                textBox1.Text += linie["numeTitular"] + "   " + linie["categorieBilet"] +
                    Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM bilete", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "bilete");

            DataTable tabela = ds.Tables["bilete"];

            adaptor.UpdateCommand = new OleDbCommand("UPDATE bilete SET categorieBilet='" + comboBox1.Text + "'", conexiune);

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
                comanda.CommandText = "CREATE PROCEDURE BileteCategorie AS SELECT * FROM bilete WHERE categorieBilet=@categorieBilet";
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
                comanda.CommandText = "BileteCategorie";
                comanda.CommandType = CommandType.StoredProcedure;
                comanda.Parameters.Add("@categorieBilet", OleDbType.Char, 20).Value = comboBox1.Text;
                OleDbDataReader reader = comanda.ExecuteReader();
                while(reader.Read())
                {
                    textBox1.Text += reader["numeTitular"] + "   " + reader["categorieBilet"] +
                        Environment.NewLine;
                }
                reader.Close();
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
