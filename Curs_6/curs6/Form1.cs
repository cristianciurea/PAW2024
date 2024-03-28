using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs6
{
    public partial class Form1 : Form
    {

        ArrayList listaStud = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int cnp = Convert.ToInt32(tbCnp.Text);
                string nume = tbNume.Text;
                char sex = Convert.ToChar(cbSex.Text);
                float medie = (float)Convert.ToDouble(tbMedie.Text);

                Student s = new Student(cnp, nume, sex, medie);
                MessageBox.Show(s.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                //this.BackColor = dlg.Color;
                //textBox1.BackColor = dlg.Color;
                contextMenuStrip1.SourceControl.BackColor = dlg.Color;
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                contextMenuStrip1.SourceControl.Font = dlg.Font;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void textBoxMedie_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                float medie = (float)Convert.ToDouble(textBoxMedie.Text);
                if (medie < 1 || medie > 10)
                    MessageBox.Show("Media trebuie intre 1 - 10!");
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCnp.Text == "")
                errorProvider1.SetError(textBoxCnp, "Introduceti cnp!");
            else
                if (textBoxNume.Text == "")
                errorProvider1.SetError(textBoxNume, "Introduceti nume!");
            else
                if (comboBoxSex.Text == "")
                errorProvider1.SetError(comboBoxSex, "Selectati sex!");
            else
                if (textBoxMedie.Text == "")
                errorProvider1.SetError(textBoxMedie, "Introduceti medie!");
            else
                if((textBoxCnp.Text.Substring(0, 1)=="1" ||
                textBoxCnp.Text.Substring(0, 1) == "5") && comboBoxSex.Text=="F" )
            {
                errorProvider1.SetError(textBoxCnp, "CNP nu corespunde cu sex!");
                errorProvider1.SetError(comboBoxSex, "Sex nu corespunde cu cnp!");
            }
            else
            {
                try
                {
                    int cnp = Convert.ToInt32(textBoxCnp.Text);
                    string nume = textBoxNume.Text;
                    char sex = Convert.ToChar(comboBoxSex.Text);
                    float medie = (float)Convert.ToDouble(textBoxMedie.Text);

                    Student s = new Student(cnp, nume, sex, medie);
                    MessageBox.Show(s.ToString());

                    listaStud.Add(s);

                    throw new ExceptiaMea("Am declansat exceptia mea!");
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(ExceptiaMea ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    textBoxCnp.Clear();
                    textBoxNume.Clear();
                    comboBoxSex.Text = "";
                    textBoxMedie.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaStud);
            frm.ShowDialog();
        }
    }

    class ExceptiaMea: ApplicationException
    {
        public ExceptiaMea():base()
        {

        }

        public ExceptiaMea(string mesaj) : base(mesaj)
        {

        }
    }
}
