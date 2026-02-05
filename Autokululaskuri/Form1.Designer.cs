namespace Autokululaskuri
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
            this.HeaderLB = new System.Windows.Forms.Label();
            this.LainaLB = new System.Windows.Forms.Label();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.NesteTB = new System.Windows.Forms.TextBox();
            this.NesteLB = new System.Windows.Forms.Label();
            this.VakuutusTB = new System.Windows.Forms.TextBox();
            this.VakuutusLB = new System.Windows.Forms.Label();
            this.MuutKulutTB = new System.Windows.Forms.TextBox();
            this.MuutKulutLB = new System.Windows.Forms.Label();
            this.PolttoaineTB = new System.Windows.Forms.TextBox();
            this.PolttoaineLB = new System.Windows.Forms.Label();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.RenkaatLB = new System.Windows.Forms.Label();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.HuollotLB = new System.Windows.Forms.Label();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.PesutLB = new System.Windows.Forms.Label();
            this.KilometriLB = new System.Windows.Forms.Label();
            this.KilometriCB = new System.Windows.Forms.ComboBox();
            this.KilometriLaskuLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderLB
            // 
            this.HeaderLB.AutoSize = true;
            this.HeaderLB.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLB.Location = new System.Drawing.Point(281, 9);
            this.HeaderLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLB.Name = "HeaderLB";
            this.HeaderLB.Size = new System.Drawing.Size(404, 50);
            this.HeaderLB.TabIndex = 0;
            this.HeaderLB.Text = "Auton kustannuslaskuri";
            // 
            // LainaLB
            // 
            this.LainaLB.AutoSize = true;
            this.LainaLB.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LainaLB.Location = new System.Drawing.Point(15, 105);
            this.LainaLB.Name = "LainaLB";
            this.LainaLB.Size = new System.Drawing.Size(260, 25);
            this.LainaLB.TabIndex = 1;
            this.LainaLB.Text = "Lainan lyhennys korkoineen:";
            // 
            // LainaTB
            // 
            this.LainaTB.Location = new System.Drawing.Point(281, 102);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(101, 29);
            this.LainaTB.TabIndex = 2;
            // 
            // NesteTB
            // 
            this.NesteTB.Location = new System.Drawing.Point(281, 135);
            this.NesteTB.Name = "NesteTB";
            this.NesteTB.Size = new System.Drawing.Size(101, 29);
            this.NesteTB.TabIndex = 4;
            this.NesteTB.TextChanged += new System.EventHandler(this.NesteTB_TextChanged);
            // 
            // NesteLB
            // 
            this.NesteLB.AutoSize = true;
            this.NesteLB.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NesteLB.Location = new System.Drawing.Point(12, 138);
            this.NesteLB.Name = "NesteLB";
            this.NesteLB.Size = new System.Drawing.Size(202, 25);
            this.NesteLB.TabIndex = 3;
            this.NesteLB.Text = "Lisättävät nesteet yms:";
            // 
            // VakuutusTB
            // 
            this.VakuutusTB.Location = new System.Drawing.Point(281, 170);
            this.VakuutusTB.Name = "VakuutusTB";
            this.VakuutusTB.Size = new System.Drawing.Size(101, 29);
            this.VakuutusTB.TabIndex = 6;
            // 
            // VakuutusLB
            // 
            this.VakuutusLB.AutoSize = true;
            this.VakuutusLB.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VakuutusLB.Location = new System.Drawing.Point(12, 170);
            this.VakuutusLB.Name = "VakuutusLB";
            this.VakuutusLB.Size = new System.Drawing.Size(159, 25);
            this.VakuutusLB.TabIndex = 5;
            this.VakuutusLB.Text = "Vakuutusmaksut:";
            // 
            // MuutKulutTB
            // 
            this.MuutKulutTB.Location = new System.Drawing.Point(281, 205);
            this.MuutKulutTB.Name = "MuutKulutTB";
            this.MuutKulutTB.Size = new System.Drawing.Size(101, 29);
            this.MuutKulutTB.TabIndex = 8;
            // 
            // MuutKulutLB
            // 
            this.MuutKulutLB.AutoSize = true;
            this.MuutKulutLB.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MuutKulutLB.Location = new System.Drawing.Point(12, 205);
            this.MuutKulutLB.Name = "MuutKulutLB";
            this.MuutKulutLB.Size = new System.Drawing.Size(117, 25);
            this.MuutKulutLB.TabIndex = 7;
            this.MuutKulutLB.Text = "Muut kulut:";
            // 
            // PolttoaineTB
            // 
            this.PolttoaineTB.Location = new System.Drawing.Point(281, 240);
            this.PolttoaineTB.Name = "PolttoaineTB";
            this.PolttoaineTB.Size = new System.Drawing.Size(101, 29);
            this.PolttoaineTB.TabIndex = 10;
            // 
            // PolttoaineLB
            // 
            this.PolttoaineLB.AutoSize = true;
            this.PolttoaineLB.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PolttoaineLB.Location = new System.Drawing.Point(12, 240);
            this.PolttoaineLB.Name = "PolttoaineLB";
            this.PolttoaineLB.Size = new System.Drawing.Size(107, 25);
            this.PolttoaineLB.TabIndex = 9;
            this.PolttoaineLB.Text = "Polttoneste:";
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Location = new System.Drawing.Point(577, 173);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(108, 29);
            this.RenkaatTB.TabIndex = 16;
            // 
            // RenkaatLB
            // 
            this.RenkaatLB.AutoSize = true;
            this.RenkaatLB.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RenkaatLB.Location = new System.Drawing.Point(412, 170);
            this.RenkaatLB.Name = "RenkaatLB";
            this.RenkaatLB.Size = new System.Drawing.Size(90, 25);
            this.RenkaatLB.TabIndex = 15;
            this.RenkaatLB.Text = "Renkaat:";
            this.RenkaatLB.Click += new System.EventHandler(this.label6_Click);
            // 
            // HuollotTB
            // 
            this.HuollotTB.Location = new System.Drawing.Point(577, 138);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(108, 29);
            this.HuollotTB.TabIndex = 14;
            // 
            // HuollotLB
            // 
            this.HuollotLB.AutoSize = true;
            this.HuollotLB.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HuollotLB.Location = new System.Drawing.Point(412, 138);
            this.HuollotLB.Name = "HuollotLB";
            this.HuollotLB.Size = new System.Drawing.Size(78, 25);
            this.HuollotLB.TabIndex = 13;
            this.HuollotLB.Text = "Huollot:";
            // 
            // PesutTB
            // 
            this.PesutTB.Location = new System.Drawing.Point(577, 103);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(108, 29);
            this.PesutTB.TabIndex = 12;
            // 
            // PesutLB
            // 
            this.PesutLB.AutoSize = true;
            this.PesutLB.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PesutLB.Location = new System.Drawing.Point(412, 103);
            this.PesutLB.Name = "PesutLB";
            this.PesutLB.Size = new System.Drawing.Size(64, 25);
            this.PesutLB.TabIndex = 11;
            this.PesutLB.Text = "Pesut:";
            // 
            // KilometriLB
            // 
            this.KilometriLB.AutoSize = true;
            this.KilometriLB.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KilometriLB.Location = new System.Drawing.Point(412, 209);
            this.KilometriLB.Name = "KilometriLB";
            this.KilometriLB.Size = new System.Drawing.Size(155, 25);
            this.KilometriLB.TabIndex = 17;
            this.KilometriLB.Text = "Kilometrit/vuosi";
            // 
            // KilometriCB
            // 
            this.KilometriCB.FormattingEnabled = true;
            this.KilometriCB.Items.AddRange(new object[] {
            "1000",
            "5000",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000"});
            this.KilometriCB.Location = new System.Drawing.Point(577, 209);
            this.KilometriCB.Name = "KilometriCB";
            this.KilometriCB.Size = new System.Drawing.Size(121, 29);
            this.KilometriCB.TabIndex = 18;
            this.KilometriCB.SelectedIndexChanged += new System.EventHandler(this.KilometriCB_SelectedIndexChanged);
            // 
            // KilometriLaskuLB
            // 
            this.KilometriLaskuLB.AutoSize = true;
            this.KilometriLaskuLB.Location = new System.Drawing.Point(25, 300);
            this.KilometriLaskuLB.Name = "KilometriLaskuLB";
            this.KilometriLaskuLB.Size = new System.Drawing.Size(130, 21);
            this.KilometriLaskuLB.TabIndex = 19;
            this.KilometriLaskuLB.Text = "KilometriLaskuLB";
            this.KilometriLaskuLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.KilometriLaskuLB);
            this.Controls.Add(this.KilometriCB);
            this.Controls.Add(this.KilometriLB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.RenkaatLB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.HuollotLB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.PesutLB);
            this.Controls.Add(this.PolttoaineTB);
            this.Controls.Add(this.PolttoaineLB);
            this.Controls.Add(this.MuutKulutTB);
            this.Controls.Add(this.MuutKulutLB);
            this.Controls.Add(this.VakuutusTB);
            this.Controls.Add(this.VakuutusLB);
            this.Controls.Add(this.NesteTB);
            this.Controls.Add(this.NesteLB);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.LainaLB);
            this.Controls.Add(this.HeaderLB);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLB;
        private Label LainaLB;
        private TextBox LainaTB;
        private TextBox NesteTB;
        private Label NesteLB;
        private TextBox VakuutusTB;
        private Label VakuutusLB;
        private TextBox MuutKulutTB;
        private Label MuutKulutLB;
        private TextBox PolttoaineTB;
        private Label PolttoaineLB;
        private TextBox RenkaatTB;
        private Label RenkaatLB;
        private TextBox HuollotTB;
        private Label HuollotLB;
        private TextBox PesutTB;
        private Label PesutLB;
        private Label KilometriLB;
        private ComboBox KilometriCB;
        private Label KilometriLaskuLB;
    }
}