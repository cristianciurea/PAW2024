
namespace Sem6PAW_1063
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbEUR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUSD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGBP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbXAU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data curs:";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(87, 16);
            this.tbData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(68, 20);
            this.tbData.TabIndex = 1;
            // 
            // tbEUR
            // 
            this.tbEUR.AcceptsReturn = true;
            this.tbEUR.Location = new System.Drawing.Point(87, 62);
            this.tbEUR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEUR.Name = "tbEUR";
            this.tbEUR.Size = new System.Drawing.Size(68, 20);
            this.tbEUR.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EUR:";
            // 
            // tbUSD
            // 
            this.tbUSD.Location = new System.Drawing.Point(87, 110);
            this.tbUSD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUSD.Name = "tbUSD";
            this.tbUSD.Size = new System.Drawing.Size(68, 20);
            this.tbUSD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "USD:";
            // 
            // tbGBP
            // 
            this.tbGBP.Location = new System.Drawing.Point(87, 158);
            this.tbGBP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGBP.Name = "tbGBP";
            this.tbGBP.Size = new System.Drawing.Size(68, 20);
            this.tbGBP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "GBP:";
            // 
            // tbXAU
            // 
            this.tbXAU.Location = new System.Drawing.Point(87, 213);
            this.tbXAU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbXAU.Name = "tbXAU";
            this.tbXAU.Size = new System.Drawing.Size(68, 20);
            this.tbXAU.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "XAU:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Parsare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Generare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(294, 16);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(221, 186);
            this.treeView1.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Incarca tree";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 369);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbXAU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbGBP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEUR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbEUR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGBP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbXAU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button3;
    }
}

