namespace OppilaitoksenTiedot
{
    partial class OppilaitosFM
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
            this.OppilaitosLB = new System.Windows.Forms.Label();
            this.VastuuhloLB = new System.Windows.Forms.Label();
            this.oppiLaitosCB = new System.Windows.Forms.ComboBox();
            this.vastuuHloCB = new System.Windows.Forms.ComboBox();
            this.katuosoiteLB = new System.Windows.Forms.Label();
            this.postinumeroLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.postitoimipaikkaLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.sijaintiLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // OppilaitosLB
            // 
            this.OppilaitosLB.AutoSize = true;
            this.OppilaitosLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OppilaitosLB.Location = new System.Drawing.Point(30, 75);
            this.OppilaitosLB.Name = "OppilaitosLB";
            this.OppilaitosLB.Size = new System.Drawing.Size(130, 21);
            this.OppilaitosLB.TabIndex = 1;
            this.OppilaitosLB.Text = "Valitse oppilaitos:";
            // 
            // VastuuhloLB
            // 
            this.VastuuhloLB.AutoSize = true;
            this.VastuuhloLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastuuhloLB.Location = new System.Drawing.Point(235, 75);
            this.VastuuhloLB.Name = "VastuuhloLB";
            this.VastuuhloLB.Size = new System.Drawing.Size(159, 21);
            this.VastuuhloLB.TabIndex = 2;
            this.VastuuhloLB.Text = "Valitse vastuuhenkilö:";
            // 
            // oppiLaitosCB
            // 
            this.oppiLaitosCB.FormattingEnabled = true;
            this.oppiLaitosCB.Location = new System.Drawing.Point(32, 99);
            this.oppiLaitosCB.Name = "oppiLaitosCB";
            this.oppiLaitosCB.Size = new System.Drawing.Size(128, 23);
            this.oppiLaitosCB.TabIndex = 3;
            this.oppiLaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppiLaitosCB_SelectedIndexChanged);
            // 
            // vastuuHloCB
            // 
            this.vastuuHloCB.FormattingEnabled = true;
            this.vastuuHloCB.Location = new System.Drawing.Point(235, 99);
            this.vastuuHloCB.Name = "vastuuHloCB";
            this.vastuuHloCB.Size = new System.Drawing.Size(159, 23);
            this.vastuuHloCB.TabIndex = 4;
            this.vastuuHloCB.TextChanged += new System.EventHandler(this.vastuuHloCB_TextChanged);
            // 
            // katuosoiteLB
            // 
            this.katuosoiteLB.AutoSize = true;
            this.katuosoiteLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.katuosoiteLB.Location = new System.Drawing.Point(32, 134);
            this.katuosoiteLB.Name = "katuosoiteLB";
            this.katuosoiteLB.Size = new System.Drawing.Size(52, 21);
            this.katuosoiteLB.TabIndex = 5;
            this.katuosoiteLB.Text = "label2";
            // 
            // postinumeroLB
            // 
            this.postinumeroLB.AutoSize = true;
            this.postinumeroLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postinumeroLB.Location = new System.Drawing.Point(32, 155);
            this.postinumeroLB.Name = "postinumeroLB";
            this.postinumeroLB.Size = new System.Drawing.Size(52, 21);
            this.postinumeroLB.TabIndex = 6;
            this.postinumeroLB.Text = "label3";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.puhelinLB.Location = new System.Drawing.Point(32, 197);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(52, 21);
            this.puhelinLB.TabIndex = 8;
            this.puhelinLB.Text = "label4";
            // 
            // postitoimipaikkaLB
            // 
            this.postitoimipaikkaLB.AutoSize = true;
            this.postitoimipaikkaLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postitoimipaikkaLB.Location = new System.Drawing.Point(32, 176);
            this.postitoimipaikkaLB.Name = "postitoimipaikkaLB";
            this.postitoimipaikkaLB.Size = new System.Drawing.Size(52, 21);
            this.postitoimipaikkaLB.TabIndex = 7;
            this.postitoimipaikkaLB.Text = "label5";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLB.Location = new System.Drawing.Point(235, 197);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(52, 21);
            this.phoneLB.TabIndex = 12;
            this.phoneLB.Text = "label4";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLB.Location = new System.Drawing.Point(235, 176);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(52, 21);
            this.emailLB.TabIndex = 11;
            this.emailLB.Text = "label5";
            // 
            // sijaintiLB
            // 
            this.sijaintiLB.AutoSize = true;
            this.sijaintiLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sijaintiLB.Location = new System.Drawing.Point(235, 155);
            this.sijaintiLB.Name = "sijaintiLB";
            this.sijaintiLB.Size = new System.Drawing.Size(52, 21);
            this.sijaintiLB.TabIndex = 10;
            this.sijaintiLB.Text = "label3";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titteliLB.Location = new System.Drawing.Point(235, 134);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(52, 21);
            this.titteliLB.TabIndex = 9;
            this.titteliLB.Text = "label2";
            // 
            // OppilaitosFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.phoneLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.sijaintiLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.postitoimipaikkaLB);
            this.Controls.Add(this.postinumeroLB);
            this.Controls.Add(this.katuosoiteLB);
            this.Controls.Add(this.vastuuHloCB);
            this.Controls.Add(this.oppiLaitosCB);
            this.Controls.Add(this.VastuuhloLB);
            this.Controls.Add(this.OppilaitosLB);
            this.Controls.Add(this.label1);
            this.Name = "OppilaitosFM";
            this.Text = "Oppilaitoksen avainhenkilöt";
            this.Load += new System.EventHandler(this.OppilaitosFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Label OppilaitosLB;
        private Label VastuuhloLB;
        private ComboBox oppiLaitosCB;
        private ComboBox vastuuHloCB;
        private Label katuosoiteLB;
        private Label postinumeroLB;
        private Label puhelinLB;
        private Label postitoimipaikkaLB;
        private Label phoneLB;
        private Label emailLB;
        private Label sijaintiLB;
        private Label titteliLB;
    }
}