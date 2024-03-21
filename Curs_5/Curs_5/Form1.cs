using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ArrayList listaPct;
        Graphics context;
        bool mouseApasat;
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            listaPct = new ArrayList();
            //bmp = new Bitmap(this.Width, this.Height);
            bmp = new Bitmap(panel1.Width, panel1.Height);
            //context = this.CreateGraphics();
            context = Graphics.FromImage(bmp);
            hScrollBar1.Visible = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listaPct.Add(p);
                mouseApasat = true;
                label1.Text = "Form1_MouseDown";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listaPct.Add(p);
                Pen creion = new Pen(this.ForeColor);
                creion.Width = hScrollBar1.Value;
                if(mouseApasat==true)
                {
                    context.DrawLine(creion, (Point)listaPct[listaPct.Count - 2],
                        (Point)listaPct[listaPct.Count - 1]);
                    label1.Text = "Form1_MouseMove";
                    //this.Invalidate();
                    panel1.Invalidate();
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseApasat = false;
                label1.Text = "Form1_MouseUp";
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.ForeColor = dlg.Color;
        }

        private void schimbaGrosimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hScrollBar1.Visible = true;
        }

        public void salvare(Control c, string denumire)
        {
            Graphics gr = c.CreateGraphics();
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X,
                c.ClientRectangle.Y, c.ClientRectangle.Width,
                c.ClientRectangle.Height));
            img.Save(denumire);
            img.Dispose();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //salvare(this, "poza.bmp");
            hScrollBar1.Visible = false;
            label1.Visible = false;
            salvare(panel1, "poza.bmp");
            MessageBox.Show("Poza salvata!");
        }
    }
}
