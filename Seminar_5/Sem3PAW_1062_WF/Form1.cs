﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Sem3PAW_1062_WF
{
    public partial class Form1 : Form
    {

        List<Student> listaStud = new List<Student>();

        ArrayList listaTb = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            listaTb.Add(textBox1);
            tbNote.Visible = false;
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCod.Text == "")
                errorProvider1.SetError(tbCod, "Introduceti codul!");
            else
                if (cbSex.Text == "")
                errorProvider1.SetError(cbSex, "Selectati sexul!");
            else
                if (tbVarsta.Text == "")
                errorProvider1.SetError(tbVarsta, "Introduceti varsta!");
            else
                if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            /*else
                if (tbNote.Text == "")
                errorProvider1.SetError(tbNote, "Introduceti notele!");*/
            else
            {
                errorProvider1.Clear();
                try
                {
                    int cod = Convert.ToInt32(tbCod.Text);
                    char sex = Convert.ToChar(cbSex.Text);
                    int varsta = Convert.ToInt32(tbVarsta.Text);
                    string nume = tbNume.Text;
                    string noteS = tbNote.Text;
                    /*string[] vectNoteS = noteS.Split(',');
                    int[] vectNote = new int[vectNoteS.Length];
                    for (int i = 0; i < vectNoteS.Length; i++)
                        vectNote[i] = Convert.ToInt32(vectNoteS[i]);*/
                    

                    
                    int[] vectNote = new int[listaTb.Count];
                    for (int i = 0; i < listaTb.Count; i++)
                        vectNote[i] = Convert.ToInt32(((TextBox)listaTb[i]).Text);

                    Student stud = new Student(cod, sex, varsta, nume, vectNote);
                    MessageBox.Show(stud.ToString());
                    listaStud.Add(stud);

                    salvareFisierTextToolStripMenuItem_Click(this, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCod.Clear();
                    cbSex.Text = "";
                    tbVarsta.Clear();
                    tbNume.Clear();
                    //tbNote.Clear();
                    for (int i = 0; i < listaTb.Count; i++)
                        ((TextBox)listaTb[i]).Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaStud);
            //frm.Show();
            frm.ShowDialog();
        }

        private void salvareFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            sw.WriteLine(tbCod.Text);
            sw.WriteLine(cbSex.Text);
            sw.WriteLine(tbVarsta.Text);
            sw.WriteLine(tbNume.Text);
            sw.WriteLine(tbNote.Text);
            sw.Close();
        }

        private void citireDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            tbCod.Text = sr.ReadLine();
            cbSex.Text = sr.ReadLine();
            tbVarsta.Text = sr.ReadLine();
            tbNume.Text = sr.ReadLine();
            tbNote.Text = sr.ReadLine();
            sr.Close();
        }

        private void tbCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9'
                || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9'
                || e.KeyChar == (char)8 || e.KeyChar==',')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = textBox1.Location.X;
            int y = ((TextBox)listaTb[listaTb.Count - 1]).Location.Y;
            int size = textBox1.Width;
            TextBox tbNou = new TextBox();
            tbNou.Location = new Point(x, y + 40);
            tbNou.Width = size;

            tbNou.KeyPress += new KeyPressEventHandler(tbCod_KeyPress);
            tbNou.Validating += new CancelEventHandler(textBox1_Validating);

            this.Controls.Add(tbNou);
            listaTb.Add(tbNou);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listaTb.Count > 1)
            {
                TextBox tbSters = (TextBox)listaTb[listaTb.Count - 1];

                listaTb.Remove(tbSters);
                this.Controls.Remove(tbSters);
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TextBox tb = (TextBox)sender;
                int nota = Convert.ToInt32(tb.Text);
                if (nota < 1 || nota > 10)
                    MessageBox.Show("Nota trebuie intre 1-10!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
