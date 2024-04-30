
namespace Sem10PAW_1062
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbForma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMedia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(213, 72);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 26);
            this.tbNume.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forma";
            // 
            // cbForma
            // 
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Location = new System.Drawing.Point(213, 135);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(121, 28);
            this.cbForma.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Media";
            // 
            // tbMedia
            // 
            this.tbMedia.Location = new System.Drawing.Point(213, 198);
            this.tbMedia.Name = "tbMedia";
            this.tbMedia.Size = new System.Drawing.Size(100, 26);
            this.tbMedia.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADAUGA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbForma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbForma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMedia;
        private System.Windows.Forms.Button button1;
    }
}