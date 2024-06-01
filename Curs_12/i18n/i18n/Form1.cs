using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Threading;

namespace i18n
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("Spanish");
            comboBox1.Items.Add("French");
            comboBox1.Items.Add("Romana");
            comboBox1.Items.Add("Italian");
            comboBox1.Items.Add("German");
            comboBox1.Items.Add("Turkish");
            comboBox1.SelectedIndex = 0;
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "English")
            {
                ChangeLanguage("en");
            }
            else if (comboBox1.SelectedItem.ToString() == "Spanish")
            {
                ChangeLanguage("es-ES");
            }
            else if (comboBox1.SelectedItem.ToString() == "French")
            {
                ChangeLanguage("fr-FR");
            }
            else if (comboBox1.SelectedItem.ToString() == "Romana")
            {
                ChangeLanguage("ro-RO");
            }
            else if (comboBox1.SelectedItem.ToString() == "Italian")
            {
                ChangeLanguage("it-IT");
            }
            else if (comboBox1.SelectedItem.ToString() == "German")
            {
                ChangeLanguage("de-DE");
            }
            else if (comboBox1.SelectedItem.ToString() == "Turkish")
            {
                ChangeLanguage("tr-TR");
            }
        }
    }
}
