namespace LukujenJarjestys
{
    partial class LukujenJarjestys
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnnaLukuLB = new System.Windows.Forms.Label();
            this.UusiLukuTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnnaLukuLB
            // 
            this.AnnaLukuLB.AutoSize = true;
            this.AnnaLukuLB.Location = new System.Drawing.Point(55, 28);
            this.AnnaLukuLB.Name = "AnnaLukuLB";
            this.AnnaLukuLB.Size = new System.Drawing.Size(140, 15);
            this.AnnaLukuLB.TabIndex = 0;
            this.AnnaLukuLB.Text = "Anna luku (-999 lopetus):";
            this.AnnaLukuLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // UusiLukuTB
            // 
            this.UusiLukuTB.Location = new System.Drawing.Point(201, 25);
            this.UusiLukuTB.Name = "UusiLukuTB";
            this.UusiLukuTB.Size = new System.Drawing.Size(148, 23);
            this.UusiLukuTB.TabIndex = 1;
            this.UusiLukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UusiLukuTB_KeyPress);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(62, 67);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(38, 15);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "label1";
            this.VastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 149);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.UusiLukuTB);
            this.Controls.Add(this.AnnaLukuLB);
            this.Name = "LukujenJarjestys";
            this.Text = "Lukujen järjestys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AnnaLukuLB;
        private TextBox UusiLukuTB;
        private Label VastausLB;
    }
}