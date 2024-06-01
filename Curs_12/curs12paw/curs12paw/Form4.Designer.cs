
namespace curs12paw
{
    partial class Form4
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
            this.listaTari1 = new curs12paw.ListaTari();
            this.ceas1 = new curs12paw.Ceas();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(278, 26);
            this.login1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(460, 235);
            this.login1.TabIndex = 0;
            // 
            // listaTari1
            // 
            this.listaTari1.Location = new System.Drawing.Point(351, 316);
            this.listaTari1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaTari1.Name = "listaTari1";
            this.listaTari1.Size = new System.Drawing.Size(375, 68);
            this.listaTari1.TabIndex = 1;
            // 
            // ceas1
            // 
            this.ceas1.Location = new System.Drawing.Point(53, 256);
            this.ceas1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ceas1.Name = "ceas1";
            this.ceas1.Size = new System.Drawing.Size(392, 63);
            this.ceas1.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ceas1);
            this.Controls.Add(this.listaTari1);
            this.Controls.Add(this.login1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private Login.Login login1;
        private ListaTari listaTari1;
        private Ceas ceas1;
    }
}