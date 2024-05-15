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
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            comboBox1.Visible = false;
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = masini.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                //MessageBox.Show("S-a deschis!");
                OleDbCommand comanda = new OleDbCommand();
                comanda.CommandText = "SELECT * FROM masini";
                comanda.Connection = conexiune;
                OleDbDataReader reader = comanda.ExecuteReader();
                while(reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["cod"].ToString());
                    itm.SubItems.Add(reader["marca"].ToString());
                    itm.SubItems.Add(reader["model"].ToString());
                    itm.SubItems.Add(reader["motorizare"].ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach(ListViewItem itm in listView1.Items)
                    if(itm.Checked)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "UPDATE masini SET motorizare='"+comboBox1.Text+"' WHERE cod=" + cod;
                        comanda.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                button1_Click(sender, e);
                button2.Visible = false;
                comboBox1.Visible = false;
                button3.Visible = true;
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM masini WHERE cod=" + cod;
                        comanda.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                button1_Click(sender, e);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            comboBox1.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
