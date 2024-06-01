namespace curs12paw
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
            this.linkLabel1 = new curs12paw.LinkLabel();
            this.linkLabelSite1 = new curs12paw.LinkLabelSite();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(603, 268);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(228, 69);
            this.linkLabel1.TabIndex = 0;
            // 
            // linkLabelSite1
            // 
            this.linkLabelSite1.Location = new System.Drawing.Point(583, 26);
            this.linkLabelSite1.Name = "linkLabelSite1";
            this.linkLabelSite1.Size = new System.Drawing.Size(277, 81);
            this.linkLabelSite1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 355);
            this.Controls.Add(this.linkLabelSite1);
            this.Controls.Add(this.linkLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabelSite linkLabelSite1;
    }
}