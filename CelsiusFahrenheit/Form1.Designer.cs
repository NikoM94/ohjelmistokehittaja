namespace CelsiusFahrenheit
{
    partial class CelsiusToFahrenheit
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
            this.DegreesInputLB = new System.Windows.Forms.Label();
            this.AsteetTB = new System.Windows.Forms.TextBox();
            this.MuuntoGB = new System.Windows.Forms.GroupBox();
            this.CelsiusRB = new System.Windows.Forms.RadioButton();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuuntoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // DegreesInputLB
            // 
            this.DegreesInputLB.AutoSize = true;
            this.DegreesInputLB.Location = new System.Drawing.Point(47, 44);
            this.DegreesInputLB.Name = "DegreesInputLB";
            this.DegreesInputLB.Size = new System.Drawing.Size(75, 15);
            this.DegreesInputLB.TabIndex = 0;
            this.DegreesInputLB.Text = "Anna asteet: ";
            // 
            // AsteetTB
            // 
            this.AsteetTB.Location = new System.Drawing.Point(128, 41);
            this.AsteetTB.Name = "AsteetTB";
            this.AsteetTB.Size = new System.Drawing.Size(46, 23);
            this.AsteetTB.TabIndex = 1;
            // 
            // MuuntoGB
            // 
            this.MuuntoGB.Controls.Add(this.FahrenheitRB);
            this.MuuntoGB.Controls.Add(this.CelsiusRB);
            this.MuuntoGB.Location = new System.Drawing.Point(180, 12);
            this.MuuntoGB.Name = "MuuntoGB";
            this.MuuntoGB.Size = new System.Drawing.Size(110, 88);
            this.MuuntoGB.TabIndex = 2;
            this.MuuntoGB.TabStop = false;
            this.MuuntoGB.Text = "Miten muunnat?";
            // 
            // CelsiusRB
            // 
            this.CelsiusRB.AutoSize = true;
            this.CelsiusRB.Location = new System.Drawing.Point(6, 22);
            this.CelsiusRB.Name = "CelsiusRB";
            this.CelsiusRB.Size = new System.Drawing.Size(62, 19);
            this.CelsiusRB.TabIndex = 0;
            this.CelsiusRB.TabStop = true;
            this.CelsiusRB.Text = "Celsius";
            this.CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Location = new System.Drawing.Point(6, 47);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(81, 19);
            this.FahrenheitRB.TabIndex = 1;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Location = new System.Drawing.Point(296, 40);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(75, 23);
            this.MuunnaBT.TabIndex = 3;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(47, 85);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(52, 15);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "Vastaus: ";
            this.VastausLB.Click += new System.EventHandler(this.VastausLB_Click);
            // 
            // CelsiusToFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 126);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.MuuntoGB);
            this.Controls.Add(this.AsteetTB);
            this.Controls.Add(this.DegreesInputLB);
            this.Name = "CelsiusToFahrenheit";
            this.Text = "CelsiusToFahrenheit";
            this.MuuntoGB.ResumeLayout(false);
            this.MuuntoGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DegreesInputLB;
        private TextBox AsteetTB;
        private GroupBox MuuntoGB;
        private RadioButton FahrenheitRB;
        private RadioButton CelsiusRB;
        private Button MuunnaBT;
        private Label VastausLB;
    }
}