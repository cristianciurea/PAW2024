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
    public partial class Form2 : Form
    {
        int y = 10;

        Student[] vs = {new Student(21, "Dorel", 9.5f),
        new Student(22, "Gigel", 9),
        new Student(23, "Maricica", 10)};

        public Form2()
        {
            InitializeComponent();
            foreach (Student s in vs)
                listBox1.Items.Add(s.ToString());
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy | 
                DragDropEffects.Move);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) &&
                (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            Graphics gr = panel1.CreateGraphics();
            gr.DrawString(text, this.Font, new SolidBrush(Color.Red), 10, y);
            y += 20;
            if (e.Effect == DragDropEffects.Move)
            {
                textBox1.Clear();
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            if(y>panel1.Height)
            {
                MessageBox.Show("Cosul e plin!");
                panel1.Invalidate();
                y = 10;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(listBox1.Items.Count>0)
            listBox1.DoDragDrop(listBox1.SelectedItem,
                DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) &&
                (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            foreach (Student s in vs)
                if (s.nume == text)
                    listBox1.Items.Add(s.ToString());
                
            if (e.Effect == DragDropEffects.Move)
            {
                textBox1.Clear();
            }
        }
    }
}
