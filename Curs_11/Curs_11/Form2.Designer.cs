
namespace Curs_10
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNume = new System.Windows.Forms.TextBox();
            this.cbForma = new System.Windows.Forms.ComboBox();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl11 = new Curs_10.UserControl1();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(136, 54);
            this.tbNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(76, 20);
            this.tbNume.TabIndex = 0;
            // 
            // cbForma
            // 
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Items.AddRange(new object[] {
            "ZI",
            "ID"});
            this.cbForma.Location = new System.Drawing.Point(136, 115);
            this.cbForma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(92, 21);
            this.cbForma.TabIndex = 1;
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(136, 176);
            this.tbMedie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(76, 20);
            this.tbMedie.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(38, 350);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(325, 56);
            this.userControl11.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 418);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.cbForma);
            this.Controls.Add(this.tbNume);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.ComboBox cbForma;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.Button button1;
        private UserControl1 userControl11;
    }
}