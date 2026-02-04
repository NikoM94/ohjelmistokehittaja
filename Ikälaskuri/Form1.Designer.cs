namespace Ikälaskuri
{
    partial class IkalaskuriFM
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
            this.SynttariDT = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.VuosiLB = new System.Windows.Forms.Label();
            this.KuukausiLB = new System.Windows.Forms.Label();
            this.PaivaLB = new System.Windows.Forms.Label();
            this.TuntiLB = new System.Windows.Forms.Label();
            this.MinuuttiLB = new System.Windows.Forms.Label();
            this.SekuntiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SynttariDT
            // 
            this.SynttariDT.Location = new System.Drawing.Point(12, 12);
            this.SynttariDT.Name = "SynttariDT";
            this.SynttariDT.Size = new System.Drawing.Size(200, 29);
            this.SynttariDT.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Laske";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VuosiLB
            // 
            this.VuosiLB.AutoSize = true;
            this.VuosiLB.Location = new System.Drawing.Point(22, 61);
            this.VuosiLB.Name = "VuosiLB";
            this.VuosiLB.Size = new System.Drawing.Size(54, 21);
            this.VuosiLB.TabIndex = 2;
            this.VuosiLB.Text = "vuotta";
            this.VuosiLB.Visible = false;
            // 
            // KuukausiLB
            // 
            this.KuukausiLB.AutoSize = true;
            this.KuukausiLB.Location = new System.Drawing.Point(22, 95);
            this.KuukausiLB.Name = "KuukausiLB";
            this.KuukausiLB.Size = new System.Drawing.Size(79, 21);
            this.KuukausiLB.TabIndex = 3;
            this.KuukausiLB.Text = "kuukautta";
            this.KuukausiLB.Visible = false;
            // 
            // PaivaLB
            // 
            this.PaivaLB.AutoSize = true;
            this.PaivaLB.Location = new System.Drawing.Point(22, 128);
            this.PaivaLB.Name = "PaivaLB";
            this.PaivaLB.Size = new System.Drawing.Size(55, 21);
            this.PaivaLB.TabIndex = 4;
            this.PaivaLB.Text = "päivää";
            this.PaivaLB.Visible = false;
            // 
            // TuntiLB
            // 
            this.TuntiLB.AutoSize = true;
            this.TuntiLB.Location = new System.Drawing.Point(126, 61);
            this.TuntiLB.Name = "TuntiLB";
            this.TuntiLB.Size = new System.Drawing.Size(50, 21);
            this.TuntiLB.TabIndex = 5;
            this.TuntiLB.Text = "tuntia";
            this.TuntiLB.Visible = false;
            // 
            // MinuuttiLB
            // 
            this.MinuuttiLB.AutoSize = true;
            this.MinuuttiLB.Location = new System.Drawing.Point(126, 95);
            this.MinuuttiLB.Name = "MinuuttiLB";
            this.MinuuttiLB.Size = new System.Drawing.Size(77, 21);
            this.MinuuttiLB.TabIndex = 6;
            this.MinuuttiLB.Text = "minuuttia";
            this.MinuuttiLB.Visible = false;
            this.MinuuttiLB.Click += new System.EventHandler(this.MinuuttiLB_Click);
            // 
            // SekuntiLB
            // 
            this.SekuntiLB.AutoSize = true;
            this.SekuntiLB.Location = new System.Drawing.Point(126, 128);
            this.SekuntiLB.Name = "SekuntiLB";
            this.SekuntiLB.Size = new System.Drawing.Size(68, 21);
            this.SekuntiLB.TabIndex = 7;
            this.SekuntiLB.Text = "sekuntia";
            this.SekuntiLB.Visible = false;
            // 
            // IkalaskuriFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 378);
            this.Controls.Add(this.SekuntiLB);
            this.Controls.Add(this.MinuuttiLB);
            this.Controls.Add(this.TuntiLB);
            this.Controls.Add(this.PaivaLB);
            this.Controls.Add(this.KuukausiLB);
            this.Controls.Add(this.VuosiLB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SynttariDT);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IkalaskuriFM";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker SynttariDT;
        private Button button1;
        private Label VuosiLB;
        private Label KuukausiLB;
        private Label PaivaLB;
        private Label TuntiLB;
        private Label MinuuttiLB;
        private Label SekuntiLB;
    }
}