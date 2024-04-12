using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs8
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            //g = this.CreateGraphics();
            //g = Graphics.FromHwnd(this.Handle);
            //bmp = new Bitmap(this.Width, this.Height);
            bmp = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bmp);
        }

        private void dreptunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.DrawRectangle(pen, rec);
            g.DrawString("Dreptunghi", this.Font,
                new SolidBrush(Color.Black), 40, 40);
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void elipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.DrawEllipse(pen, rec);
            g.DrawString("Elipsa", this.Font,
                new SolidBrush(Color.Black), 40, 60);
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void placintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Green, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.DrawPie(pen, rec, 150, 300);
            g.DrawString("Placinta", this.Font,
                new SolidBrush(Color.Black), 40, 80);
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void linieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Black, 5);
            g.DrawLine(pen, 0, 0, 100, 100);
            g.DrawString("Linie", this.Font,
                new SolidBrush(Color.Black), 40,100);
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void umpleDreptunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Aquamarine);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.FillRectangle(br, rec);
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void umpleElipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Violet);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.FillEllipse(br, rec);
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void umplePlacintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Purple);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            g.FillPie(br, rec, 150, 300);
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void save(Control c, string denumire)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X,
                c.ClientRectangle.Y,
                c.ClientRectangle.Width,
                c.ClientRectangle.Height));
            img.Save(denumire);
            img.Dispose();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save(this, "poza.bmp");
            save(panel1, "poza.bmp");
            MessageBox.Show("Salvat!");
        }
    }
}
