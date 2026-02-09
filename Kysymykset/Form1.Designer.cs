namespace Kysymykset
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.VastausGB = new System.Windows.Forms.GroupBox();
            this.D_RB = new System.Windows.Forms.RadioButton();
            this.C_RB = new System.Windows.Forms.RadioButton();
            this.B_RB = new System.Windows.Forms.RadioButton();
            this.A_RB = new System.Windows.Forms.RadioButton();
            this.InvisRB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.VastausGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(28, 9);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(212, 25);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // VastausGB
            // 
            this.VastausGB.Controls.Add(this.D_RB);
            this.VastausGB.Controls.Add(this.C_RB);
            this.VastausGB.Controls.Add(this.B_RB);
            this.VastausGB.Controls.Add(this.A_RB);
            this.VastausGB.Controls.Add(this.InvisRB);
            this.VastausGB.Location = new System.Drawing.Point(246, 9);
            this.VastausGB.Name = "VastausGB";
            this.VastausGB.Size = new System.Drawing.Size(201, 316);
            this.VastausGB.TabIndex = 1;
            this.VastausGB.TabStop = false;
            this.VastausGB.Text = "Vastaus";
            // 
            // D_RB
            // 
            this.D_RB.AutoSize = true;
            this.D_RB.Location = new System.Drawing.Point(24, 141);
            this.D_RB.Name = "D_RB";
            this.D_RB.Size = new System.Drawing.Size(43, 29);
            this.D_RB.TabIndex = 4;
            this.D_RB.TabStop = true;
            this.D_RB.Text = "D";
            this.D_RB.UseVisualStyleBackColor = true;
            // 
            // C_RB
            // 
            this.C_RB.AutoSize = true;
            this.C_RB.Location = new System.Drawing.Point(24, 106);
            this.C_RB.Name = "C_RB";
            this.C_RB.Size = new System.Drawing.Size(42, 29);
            this.C_RB.TabIndex = 3;
            this.C_RB.TabStop = true;
            this.C_RB.Text = "C";
            this.C_RB.UseVisualStyleBackColor = true;
            // 
            // B_RB
            // 
            this.B_RB.AutoSize = true;
            this.B_RB.Location = new System.Drawing.Point(24, 71);
            this.B_RB.Name = "B_RB";
            this.B_RB.Size = new System.Drawing.Size(41, 29);
            this.B_RB.TabIndex = 2;
            this.B_RB.TabStop = true;
            this.B_RB.Text = "B";
            this.B_RB.UseVisualStyleBackColor = true;
            // 
            // A_RB
            // 
            this.A_RB.AutoSize = true;
            this.A_RB.Location = new System.Drawing.Point(23, 35);
            this.A_RB.Name = "A_RB";
            this.A_RB.Size = new System.Drawing.Size(42, 29);
            this.A_RB.TabIndex = 1;
            this.A_RB.TabStop = true;
            this.A_RB.Text = "A";
            this.A_RB.UseVisualStyleBackColor = true;
            this.A_RB.CheckedChanged += new System.EventHandler(this.A_RB_CheckedChanged);
            // 
            // InvisRB
            // 
            this.InvisRB.AutoCheck = false;
            this.InvisRB.AutoSize = true;
            this.InvisRB.Location = new System.Drawing.Point(24, 43);
            this.InvisRB.Name = "InvisRB";
            this.InvisRB.Size = new System.Drawing.Size(14, 13);
            this.InvisRB.TabIndex = 0;
            this.InvisRB.TabStop = true;
            this.InvisRB.UseVisualStyleBackColor = true;
            this.InvisRB.Visible = false;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(28, 115);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(76, 25);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 535);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.VastausGB);
            this.Controls.Add(this.KysymysLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.VastausGB.ResumeLayout(false);
            this.VastausGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KysymysLB;
        private GroupBox VastausGB;
        private RadioButton D_RB;
        private RadioButton C_RB;
        private RadioButton B_RB;
        private RadioButton A_RB;
        private RadioButton InvisRB;
        private Label VastausLB;
    }
}