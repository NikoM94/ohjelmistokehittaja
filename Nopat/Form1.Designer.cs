namespace Nopat
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
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.HeittoBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Noppa01PB
            // 
            this.Noppa02PB.Image = global::Nopat.Properties.Resources.dice01;
            this.Noppa02PB.Location = new System.Drawing.Point(13, 72);
            this.Noppa02PB.Name = "Noppa01PB";
            this.Noppa02PB.Size = new System.Drawing.Size(150, 150);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Noppa02PB.TabIndex = 0;
            this.Noppa02PB.TabStop = false;
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = global::Nopat.Properties.Resources.dice01;
            this.Noppa02PB.Location = new System.Drawing.Point(168, 72);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(150, 150);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Noppa02PB.TabIndex = 1;
            this.Noppa02PB.TabStop = false;
            // 
            // HeittoBT
            // 
            this.HeittoBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeittoBT.Location = new System.Drawing.Point(13, 228);
            this.HeittoBT.Name = "HeittoBT";
            this.HeittoBT.Size = new System.Drawing.Size(305, 45);
            this.HeittoBT.TabIndex = 2;
            this.HeittoBT.Text = "Heitä";
            this.HeittoBT.UseVisualStyleBackColor = true;
            this.HeittoBT.Click += new System.EventHandler(this.HeittoBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(61, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nopan heitto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeittoBT);
            this.Controls.Add(this.Noppa02PB);
            this.Controls.Add(this.Noppa02PB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Noppa02PB;
        private Button HeittoBT;
        private Label label1;
        private Label label2;
        private PictureBox Noppa01PB;
        private PictureBox pictureBox2;
    }
}