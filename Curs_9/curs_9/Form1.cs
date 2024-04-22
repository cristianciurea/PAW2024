using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText("text pus in Clipboard");
            Student s = new Student(21, "Gigel", 9.5f);
            Clipboard.SetDataObject(s);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string text = Clipboard.GetText();
            Graphics gr = panel1.CreateGraphics();
            /*gr.DrawString(text, this.Font,
                new SolidBrush(Color.Black), 0, 0);*/
            IDataObject o = Clipboard.GetDataObject();
            if(o.GetDataPresent(typeof(string)))
            {
                string text = o.GetData(typeof(string)).ToString();
                gr.DrawString(text, this.Font,
                new SolidBrush(Color.Black), 0, 0);
            }
            else
                if(o.GetDataPresent(typeof(Bitmap)))
            {
                Bitmap bmp = (Bitmap)o.GetData(typeof(Bitmap));
                gr.DrawImage(bmp, 0, 0);
            }
            else
                if(o.GetDataPresent(typeof(Student)))
            {
                Student s2 = (Student)o.GetData(typeof(Student));
                gr.DrawString(s2.ToString(), this.Font,
                new SolidBrush(Color.Black), 0, 0);
            }
        }
    }
}
