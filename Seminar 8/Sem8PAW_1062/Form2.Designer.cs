
namespace Sem8PAW_1062
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNrMatricol = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAnStudiu = new System.Windows.Forms.ComboBox();
            this.cbFacultate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. matricol";
            // 
            // tbNrMatricol
            // 
            this.tbNrMatricol.Location = new System.Drawing.Point(244, 62);
            this.tbNrMatricol.Name = "tbNrMatricol";
            this.tbNrMatricol.Size = new System.Drawing.Size(100, 26);
            this.tbNrMatricol.TabIndex = 1;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(244, 133);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 26);
            this.tbNume.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(244, 197);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(100, 26);
            this.tbMedie.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "An studiu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Facultate";
            // 
            // cbAnStudiu
            // 
            this.cbAnStudiu.FormattingEnabled = true;
            this.cbAnStudiu.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbAnStudiu.Location = new System.Drawing.Point(244, 255);
            this.cbAnStudiu.Name = "cbAnStudiu";
            this.cbAnStudiu.Size = new System.Drawing.Size(121, 28);
            this.cbAnStudiu.TabIndex = 9;
            // 
            // cbFacultate
            // 
            this.cbFacultate.FormattingEnabled = true;
            this.cbFacultate.Items.AddRange(new object[] {
            "CSIE",
            "REI",
            "FABBV",
            "FABIZ",
            "MRK"});
            this.cbFacultate.Location = new System.Drawing.Point(244, 323);
            this.cbFacultate.Name = "cbFacultate";
            this.cbFacultate.Size = new System.Drawing.Size(121, 28);
            this.cbFacultate.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbFacultate);
            this.Controls.Add(this.cbAnStudiu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNrMatricol);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNrMatricol;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAnStudiu;
        private System.Windows.Forms.ComboBox cbFacultate;
        private System.Windows.Forms.Button button1;
    }
}