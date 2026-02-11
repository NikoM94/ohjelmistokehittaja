namespace Nimilista2
{
    partial class Form1
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
            this.InputLB = new System.Windows.Forms.Label();
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.TarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLB
            // 
            this.InputLB.AutoSize = true;
            this.InputLB.Location = new System.Drawing.Point(35, 29);
            this.InputLB.Name = "InputLB";
            this.InputLB.Size = new System.Drawing.Size(340, 15);
            this.InputLB.TabIndex = 0;
            this.InputLB.Text = "Anna nimesi, niin tarkistan onko se 50. suosituimman joukossa:";
            // 
            // NimiTB
            // 
            this.NimiTB.Location = new System.Drawing.Point(381, 26);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(189, 23);
            this.NimiTB.TabIndex = 1;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(35, 77);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(38, 15);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "label1";
            this.VastausLB.Visible = false;
            // 
            // TarkastaBT
            // 
            this.TarkastaBT.Location = new System.Drawing.Point(381, 73);
            this.TarkastaBT.Name = "TarkastaBT";
            this.TarkastaBT.Size = new System.Drawing.Size(189, 23);
            this.TarkastaBT.TabIndex = 3;
            this.TarkastaBT.Text = "Tarkasta";
            this.TarkastaBT.UseVisualStyleBackColor = true;
            this.TarkastaBT.Click += new System.EventHandler(this.TarkastaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 137);
            this.Controls.Add(this.TarkastaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.InputLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InputLB;
        private TextBox NimiTB;
        private Label VastausLB;
        private Button TarkastaBT;
    }
}