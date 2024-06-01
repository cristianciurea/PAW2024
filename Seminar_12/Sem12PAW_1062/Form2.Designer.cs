
namespace Sem12PAW_1062
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
            this.dataOra1 = new Sem12PAW_1062.DataOra();
            this.listaTari20241 = new ListaTari.ListaTari2024();
            this.login20241 = new Login2024.Login2024();
            this.SuspendLayout();
            // 
            // dataOra1
            // 
            this.dataOra1.Location = new System.Drawing.Point(364, 368);
            this.dataOra1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataOra1.Name = "dataOra1";
            this.dataOra1.Size = new System.Drawing.Size(411, 70);
            this.dataOra1.TabIndex = 0;
            // 
            // listaTari20241
            // 
            this.listaTari20241.Location = new System.Drawing.Point(384, 248);
            this.listaTari20241.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaTari20241.Name = "listaTari20241";
            this.listaTari20241.Size = new System.Drawing.Size(374, 79);
            this.listaTari20241.TabIndex = 1;
            // 
            // login20241
            // 
            this.login20241.Location = new System.Drawing.Point(72, 51);
            this.login20241.Name = "login20241";
            this.login20241.Size = new System.Drawing.Size(325, 238);
            this.login20241.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login20241);
            this.Controls.Add(this.listaTari20241);
            this.Controls.Add(this.dataOra1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private DataOra dataOra1;
        private ListaTari.ListaTari2024 listaTari20241;
        private Login2024.Login2024 login20241;
    }
}