namespace WinFormsApp1
{
    partial class OpiskelijahallintaFM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.etunimiTB = new System.Windows.Forms.TextBox();
            this.sukunimiTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.oNumeroTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.emptyBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.updateBT = new System.Windows.Forms.Button();
            this.dbviewDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbviewDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ETUNIMI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "SUKUNIMI:";
            // 
            // idTB
            // 
            this.idTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTB.Location = new System.Drawing.Point(135, 16);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(166, 23);
            this.idTB.TabIndex = 3;
            // 
            // etunimiTB
            // 
            this.etunimiTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.etunimiTB.Location = new System.Drawing.Point(135, 46);
            this.etunimiTB.Name = "etunimiTB";
            this.etunimiTB.Size = new System.Drawing.Size(166, 23);
            this.etunimiTB.TabIndex = 4;
            // 
            // sukunimiTB
            // 
            this.sukunimiTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sukunimiTB.Location = new System.Drawing.Point(135, 75);
            this.sukunimiTB.Name = "sukunimiTB";
            this.sukunimiTB.Size = new System.Drawing.Size(166, 23);
            this.sukunimiTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(319, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "OPISKELIJANRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(319, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "SÄHKÖPOSTI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(319, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "PUHELIN:";
            // 
            // oNumeroTB
            // 
            this.oNumeroTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oNumeroTB.Location = new System.Drawing.Point(496, 75);
            this.oNumeroTB.Name = "oNumeroTB";
            this.oNumeroTB.Size = new System.Drawing.Size(166, 23);
            this.oNumeroTB.TabIndex = 11;
            // 
            // emailTB
            // 
            this.emailTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTB.Location = new System.Drawing.Point(496, 46);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(166, 23);
            this.emailTB.TabIndex = 10;
            // 
            // puhelinTB
            // 
            this.puhelinTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.puhelinTB.Location = new System.Drawing.Point(496, 16);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(166, 23);
            this.puhelinTB.TabIndex = 9;
            // 
            // emptyBT
            // 
            this.emptyBT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.emptyBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emptyBT.Location = new System.Drawing.Point(12, 104);
            this.emptyBT.Name = "emptyBT";
            this.emptyBT.Size = new System.Drawing.Size(155, 31);
            this.emptyBT.TabIndex = 12;
            this.emptyBT.Text = "TYHJENNÄ";
            this.emptyBT.UseVisualStyleBackColor = false;
            // 
            // deleteBT
            // 
            this.deleteBT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBT.Location = new System.Drawing.Point(507, 104);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(155, 31);
            this.deleteBT.TabIndex = 13;
            this.deleteBT.Text = "POISTA";
            this.deleteBT.UseVisualStyleBackColor = false;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // saveBT
            // 
            this.saveBT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.saveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBT.Location = new System.Drawing.Point(177, 104);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(155, 31);
            this.saveBT.TabIndex = 14;
            this.saveBT.Text = "TALLENNA";
            this.saveBT.UseVisualStyleBackColor = false;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // updateBT
            // 
            this.updateBT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBT.Location = new System.Drawing.Point(343, 104);
            this.updateBT.Name = "updateBT";
            this.updateBT.Size = new System.Drawing.Size(155, 31);
            this.updateBT.TabIndex = 15;
            this.updateBT.Text = "PÄIVITÄ";
            this.updateBT.UseVisualStyleBackColor = false;
            this.updateBT.Click += new System.EventHandler(this.updateBT_Click);
            // 
            // dbviewDG
            // 
            this.dbviewDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbviewDG.Location = new System.Drawing.Point(12, 141);
            this.dbviewDG.Name = "dbviewDG";
            this.dbviewDG.RowTemplate.Height = 25;
            this.dbviewDG.Size = new System.Drawing.Size(864, 369);
            this.dbviewDG.TabIndex = 16;
            this.dbviewDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbviewDG_CellContentClick);
            // 
            // OpiskelijahallintaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 522);
            this.Controls.Add(this.dbviewDG);
            this.Controls.Add(this.updateBT);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.emptyBT);
            this.Controls.Add(this.oNumeroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sukunimiTB);
            this.Controls.Add(this.etunimiTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OpiskelijahallintaFM";
            this.Text = "Opiskelijahallinta";
            this.Load += new System.EventHandler(this.OpiskelijahallintaFM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbviewDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idTB;
        private TextBox etunimiTB;
        private TextBox sukunimiTB;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox oNumeroTB;
        private TextBox emailTB;
        private TextBox puhelinTB;
        private Button emptyBT;
        private Button deleteBT;
        private Button saveBT;
        private Button updateBT;
        private DataGridView dbviewDG;
    }
}