namespace curs12paw
{
    partial class Form1
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
            this.login1 = new Login.Login();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.linkLabelSite1 = new curs12paw.LinkLabelSite();
            this.listaTari1 = new curs12paw.ListaTari();
            this.ceas1 = new curs12paw.Ceas();
            this.linkLabel1 = new curs12paw.LinkLabel();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(273, 66);
            this.login1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(518, 294);
            this.login1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(840, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "asfsa",
            "safsfsd",
            "asdasfsa"});
            this.listBox1.Location = new System.Drawing.Point(66, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 124);
            this.listBox1.TabIndex = 6;
            // 
            // linkLabelSite1
            // 
            this.linkLabelSite1.Location = new System.Drawing.Point(675, 0);
            this.linkLabelSite1.Name = "linkLabelSite1";
            this.linkLabelSite1.Size = new System.Drawing.Size(277, 81);
            this.linkLabelSite1.TabIndex = 4;
            // 
            // listaTari1
            // 
            this.listaTari1.Location = new System.Drawing.Point(66, 18);
            this.listaTari1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.listaTari1.Name = "listaTari1";
            this.listaTari1.Size = new System.Drawing.Size(422, 85);
            this.listaTari1.TabIndex = 2;
            // 
            // ceas1
            // 
            this.ceas1.Location = new System.Drawing.Point(18, 349);
            this.ceas1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ceas1.Name = "ceas1";
            this.ceas1.Size = new System.Drawing.Size(441, 78);
            this.ceas1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(698, 349);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(228, 69);
            this.linkLabel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 437);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabelSite1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.listaTari1);
            this.Controls.Add(this.ceas1);
            this.Controls.Add(this.linkLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel1;
        private Ceas ceas1;
        private ListaTari listaTari1;
        private Login.Login login1;
        private LinkLabelSite linkLabelSite1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

