using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDCursuriContext db = new BDCursuriContext(); 

            Curs c = new Curs();
            c.Name = tb_denumire.Text;
            c.Url = tb_url.Text;
            db.Cursuri.Add(c);
            db.SaveChanges();
           
            tb_denumire.Clear();
            tb_url.Clear();

            db.Dispose();

            MessageBox.Show("Curs inserat cu succes!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BDCursuriContext db = new BDCursuriContext();

            listBox1.Items.Clear();
            foreach (Curs c in db.Cursuri)
                listBox1.Items.Add(c.Id + " " + c.Name);

            db.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BDCursuriContext db = new BDCursuriContext();

            Student s = new Student();
            s.Id = Int32.Parse(tb_id.Text);
            s.LastName = tb_nume.Text;
            s.FirstName = tb_prenume.Text;
            string id = ((string)listBox1.SelectedItem).Split(' ')[0];
            s.CourseId = Int32.Parse(id);
            db.Studenti.Add(s);
            db.SaveChanges();
            
            tb_nume.Clear();
            tb_prenume.Clear();
            tb_id.Clear();

            db.Dispose();

            MessageBox.Show("Student inserat cu succes!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BDCursuriContext db = new BDCursuriContext();

            listBox2.Items.Clear();
            foreach (Student s in db.Studenti)
                listBox2.Items.Add(s.Id + " " + s.FirstName +
                    " " + s.LastName+" "+s.CourseId);

            db.Dispose();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string id = ((string)listBox1.SelectedItem).Split(' ')[0];

            BDCursuriContext db = new BDCursuriContext();

            listBox2.Items.Clear();
            foreach (Student s in db.Studenti)
                if(s.CourseId == Int32.Parse(id))
                    listBox2.Items.Add(s.Id + " " + s.FirstName +
                        " " + s.LastName + " " + s.CourseId);

            db.Dispose();
        }
    }
}
