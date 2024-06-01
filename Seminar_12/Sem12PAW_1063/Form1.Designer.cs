
namespace Sem12PAW_1063
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
            this.dataOra1 = new Sem12PAW_1063.DataOra();
            this.logo1 = new Sem12PAW_1063.Logo();
            this.listaTari10631 = new ListaTari1063.ListaTari1063();
            this.login10631 = new Login1063.Login1063();
            this.SuspendLayout();
            // 
            // dataOra1
            // 
            this.dataOra1.Location = new System.Drawing.Point(404, 462);
            this.dataOra1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataOra1.Name = "dataOra1";
            this.dataOra1.Size = new System.Drawing.Size(364, 75);
            this.dataOra1.TabIndex = 0;
            // 
            // logo1
            // 
            this.logo1.Location = new System.Drawing.Point(774, 424);
            this.logo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(158, 156);
            this.logo1.TabIndex = 1;
            // 
            // listaTari10631
            // 
            this.listaTari10631.Location = new System.Drawing.Point(38, 411);
            this.listaTari10631.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaTari10631.Name = "listaTari10631";
            this.listaTari10631.Size = new System.Drawing.Size(310, 102);
            this.listaTari10631.TabIndex = 2;
            // 
            // login10631
            // 
            this.login10631.Location = new System.Drawing.Point(35, 59);
            this.login10631.Name = "login10631";
            this.login10631.Size = new System.Drawing.Size(313, 236);
            this.login10631.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 572);
            this.Controls.Add(this.login10631);
            this.Controls.Add(this.listaTari10631);
            this.Controls.Add(this.logo1);
            this.Controls.Add(this.dataOra1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DataOra dataOra1;
        private Logo logo1;
        private ListaTari1063.ListaTari1063 listaTari10631;
        private Login1063.Login1063 login10631;
    }
}

