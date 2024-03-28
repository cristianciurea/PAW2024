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
    public partial class Form2 : Form
    {
        public Form2(ArrayList lista)
        {
            InitializeComponent();
            

            foreach(Student s in lista)
            {
                ListViewItem itm = new ListViewItem(s.Cnp.ToString());
                itm.SubItems.Add(s.Nume);
                itm.SubItems.Add(s.Sex.ToString());
                itm.SubItems.Add(s.Medie.ToString());
                listView1.Items.Add(itm);
            }
        }
    }
}
