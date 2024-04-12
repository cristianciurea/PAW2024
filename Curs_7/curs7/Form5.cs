using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs7
{
    public partial class Form5 : Form
    {
        public Form5(List<Student> lista)
        {
            InitializeComponent();
            TreeNode parinte = new TreeNode("Studenti");
            treeView1.Nodes.Add(parinte);
            foreach(Student s in lista)
            {
                TreeNode copil = new TreeNode(s.cod + "-" + s.nume + "-" + s.nota);
                parinte.Nodes.Add(copil);
            }
            treeView1.ExpandAll();
        }
    }
}
