namespace Form_01
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.szoveg1 = new System.Windows.Forms.Label();
            this.gomb1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // szoveg1
            // 
            this.szoveg1.AutoSize = true;
            this.szoveg1.Location = new System.Drawing.Point(30, 79);
            this.szoveg1.Name = "szoveg1";
            this.szoveg1.Size = new System.Drawing.Size(35, 13);
            this.szoveg1.TabIndex = 1;
            this.szoveg1.Text = "label1";
            // 
            // gomb1
            // 
            this.gomb1.Location = new System.Drawing.Point(191, 39);
            this.gomb1.Name = "gomb1";
            this.gomb1.Size = new System.Drawing.Size(75, 23);
            this.gomb1.TabIndex = 2;
            this.gomb1.Text = "Gomb1";
            this.gomb1.UseVisualStyleBackColor = true;
            this.gomb1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gomb1);
            this.Controls.Add(this.szoveg1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label szoveg1;
        private System.Windows.Forms.Button gomb1;
    }
}

