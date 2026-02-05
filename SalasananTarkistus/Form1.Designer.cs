namespace SalasananTarkistus
{
    partial class SalasanaFM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.TervetuloaLabel = new System.Windows.Forms.Label();
            this.VirheLB = new System.Windows.Forms.Label();
            this.TarkistaTB = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KayttajaLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SalasanaOikeinPanel);
            this.panel1.Controls.Add(this.VirheLB);
            this.panel1.Controls.Add(this.TarkistaTB);
            this.panel1.Controls.Add(this.SalasanaTB);
            this.panel1.Controls.Add(this.KayttajaTB);
            this.panel1.Controls.Add(this.SalasanaLB);
            this.panel1.Controls.Add(this.KayttajaLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 184);
            this.panel1.TabIndex = 0;
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPanel.Controls.Add(this.TervetuloaLabel);
            this.SalasanaOikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(564, 184);
            this.SalasanaOikeinPanel.TabIndex = 6;
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // TervetuloaLabel
            // 
            this.TervetuloaLabel.AutoSize = true;
            this.TervetuloaLabel.Location = new System.Drawing.Point(0, 15);
            this.TervetuloaLabel.Name = "TervetuloaLabel";
            this.TervetuloaLabel.Size = new System.Drawing.Size(572, 76);
            this.TervetuloaLabel.TabIndex = 0;
            this.TervetuloaLabel.Text = "Tervetuloa sivuilleni";
            // 
            // VirheLB
            // 
            this.VirheLB.AutoSize = true;
            this.VirheLB.Location = new System.Drawing.Point(58, 134);
            this.VirheLB.Name = "VirheLB";
            this.VirheLB.Size = new System.Drawing.Size(95, 32);
            this.VirheLB.TabIndex = 5;
            this.VirheLB.Text = "VirheLB";
            // 
            // TarkistaTB
            // 
            this.TarkistaTB.ForeColor = System.Drawing.Color.Black;
            this.TarkistaTB.Location = new System.Drawing.Point(58, 77);
            this.TarkistaTB.Name = "TarkistaTB";
            this.TarkistaTB.Size = new System.Drawing.Size(115, 45);
            this.TarkistaTB.TabIndex = 4;
            this.TarkistaTB.Text = "Tarkista";
            this.TarkistaTB.UseVisualStyleBackColor = true;
            this.TarkistaTB.Click += new System.EventHandler(this.TarkistaTB_Click);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(295, 83);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(192, 39);
            this.SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(295, 15);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(192, 39);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Location = new System.Drawing.Point(179, 83);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(110, 32);
            this.SalasanaLB.TabIndex = 1;
            this.SalasanaLB.Text = "Salasana:";
            this.SalasanaLB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // KayttajaLB
            // 
            this.KayttajaLB.AutoSize = true;
            this.KayttajaLB.Location = new System.Drawing.Point(112, 15);
            this.KayttajaLB.Name = "KayttajaLB";
            this.KayttajaLB.Size = new System.Drawing.Size(177, 32);
            this.KayttajaLB.TabIndex = 0;
            this.KayttajaLB.Text = "Käyttäjätunnus:";
            this.KayttajaLB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SalasanaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(564, 184);
            this.Controls.Add(this.panel1);
            this.Name = "SalasanaFM";
            this.Text = "Salasanan tarkistus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label VirheLB;
        private Button TarkistaTB;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label SalasanaLB;
        private Label KayttajaLB;
        private Panel SalasanaOikeinPanel;
        private Label TervetuloaLabel;
    }
}