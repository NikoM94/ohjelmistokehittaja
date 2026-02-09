namespace Tietovisa
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
            this.SubheaderLB = new System.Windows.Forms.Label();
            this.Q1GB = new System.Windows.Forms.GroupBox();
            this.Q1DRB = new System.Windows.Forms.RadioButton();
            this.Q1CRB = new System.Windows.Forms.RadioButton();
            this.Q1BRB = new System.Windows.Forms.RadioButton();
            this.Q1ARB = new System.Windows.Forms.RadioButton();
            this.Q2GB = new System.Windows.Forms.GroupBox();
            this.Q2DRB = new System.Windows.Forms.RadioButton();
            this.Q2CRB = new System.Windows.Forms.RadioButton();
            this.Q2BRB = new System.Windows.Forms.RadioButton();
            this.Q2ARB = new System.Windows.Forms.RadioButton();
            this.Q3GB = new System.Windows.Forms.GroupBox();
            this.Q3DRB = new System.Windows.Forms.RadioButton();
            this.Q3CRB = new System.Windows.Forms.RadioButton();
            this.Q3BRB = new System.Windows.Forms.RadioButton();
            this.Q3ARB = new System.Windows.Forms.RadioButton();
            this.Q4GB = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.ResultLB = new System.Windows.Forms.Label();
            this.CheckAnswersBT = new System.Windows.Forms.Button();
            this.Q1GB.SuspendLayout();
            this.Q2GB.SuspendLayout();
            this.Q3GB.SuspendLayout();
            this.Q4GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLB
            // 
            this.HeaderLB.AutoSize = true;
            this.HeaderLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLB.Location = new System.Drawing.Point(225, 22);
            this.HeaderLB.Name = "HeaderLB";
            this.HeaderLB.Size = new System.Drawing.Size(306, 45);
            this.HeaderLB.TabIndex = 0;
            this.HeaderLB.Text = "Ohjelmointitietovisa";
            // 
            // SubheaderLB
            // 
            this.SubheaderLB.AutoSize = true;
            this.SubheaderLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubheaderLB.Location = new System.Drawing.Point(281, 67);
            this.SubheaderLB.Name = "SubheaderLB";
            this.SubheaderLB.Size = new System.Drawing.Size(162, 21);
            this.SubheaderLB.TabIndex = 1;
            this.SubheaderLB.Text = "Testaa C# tietämystäsi";
            // 
            // Q1GB
            // 
            this.Q1GB.Controls.Add(this.Q1DRB);
            this.Q1GB.Controls.Add(this.Q1CRB);
            this.Q1GB.Controls.Add(this.Q1BRB);
            this.Q1GB.Controls.Add(this.Q1ARB);
            this.Q1GB.Location = new System.Drawing.Point(117, 123);
            this.Q1GB.Name = "Q1GB";
            this.Q1GB.Size = new System.Drawing.Size(527, 98);
            this.Q1GB.TabIndex = 2;
            this.Q1GB.TabStop = false;
            this.Q1GB.Text = "Miten geneeristä tyyppiä käytetään?";
            // 
            // Q1DRB
            // 
            this.Q1DRB.AutoSize = true;
            this.Q1DRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q1DRB.Location = new System.Drawing.Point(3, 76);
            this.Q1DRB.Name = "Q1DRB";
            this.Q1DRB.Size = new System.Drawing.Size(521, 19);
            this.Q1DRB.TabIndex = 3;
            this.Q1DRB.TabStop = true;
            this.Q1DRB.Text = "D. generic class Foo";
            this.Q1DRB.UseVisualStyleBackColor = true;
            // 
            // Q1CRB
            // 
            this.Q1CRB.AutoSize = true;
            this.Q1CRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q1CRB.Location = new System.Drawing.Point(3, 57);
            this.Q1CRB.Name = "Q1CRB";
            this.Q1CRB.Size = new System.Drawing.Size(521, 19);
            this.Q1CRB.TabIndex = 2;
            this.Q1CRB.TabStop = true;
            this.Q1CRB.Text = "C. <T>class Foo";
            this.Q1CRB.UseVisualStyleBackColor = true;
            // 
            // Q1BRB
            // 
            this.Q1BRB.AutoSize = true;
            this.Q1BRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q1BRB.Location = new System.Drawing.Point(3, 38);
            this.Q1BRB.Name = "Q1BRB";
            this.Q1BRB.Size = new System.Drawing.Size(521, 19);
            this.Q1BRB.TabIndex = 1;
            this.Q1BRB.TabStop = true;
            this.Q1BRB.Text = "B. class <T>Foo";
            this.Q1BRB.UseVisualStyleBackColor = true;
            // 
            // Q1ARB
            // 
            this.Q1ARB.AutoSize = true;
            this.Q1ARB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q1ARB.Location = new System.Drawing.Point(3, 19);
            this.Q1ARB.Name = "Q1ARB";
            this.Q1ARB.Size = new System.Drawing.Size(521, 19);
            this.Q1ARB.TabIndex = 0;
            this.Q1ARB.TabStop = true;
            this.Q1ARB.Text = "A. class Foo<T>";
            this.Q1ARB.UseVisualStyleBackColor = true;
            // 
            // Q2GB
            // 
            this.Q2GB.Controls.Add(this.Q2DRB);
            this.Q2GB.Controls.Add(this.Q2CRB);
            this.Q2GB.Controls.Add(this.Q2BRB);
            this.Q2GB.Controls.Add(this.Q2ARB);
            this.Q2GB.Location = new System.Drawing.Point(117, 224);
            this.Q2GB.Name = "Q2GB";
            this.Q2GB.Size = new System.Drawing.Size(527, 98);
            this.Q2GB.TabIndex = 4;
            this.Q2GB.TabStop = false;
            this.Q2GB.Text = "WriteLine(\'0\' - 48); tulostaa:";
            // 
            // Q2DRB
            // 
            this.Q2DRB.AutoSize = true;
            this.Q2DRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q2DRB.Location = new System.Drawing.Point(3, 76);
            this.Q2DRB.Name = "Q2DRB";
            this.Q2DRB.Size = new System.Drawing.Size(521, 19);
            this.Q2DRB.TabIndex = 3;
            this.Q2DRB.TabStop = true;
            this.Q2DRB.Text = "D. \'0\'";
            this.Q2DRB.UseVisualStyleBackColor = true;
            // 
            // Q2CRB
            // 
            this.Q2CRB.AutoSize = true;
            this.Q2CRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q2CRB.Location = new System.Drawing.Point(3, 57);
            this.Q2CRB.Name = "Q2CRB";
            this.Q2CRB.Size = new System.Drawing.Size(521, 19);
            this.Q2CRB.TabIndex = 2;
            this.Q2CRB.TabStop = true;
            this.Q2CRB.Text = "C. 0";
            this.Q2CRB.UseVisualStyleBackColor = true;
            // 
            // Q2BRB
            // 
            this.Q2BRB.AutoSize = true;
            this.Q2BRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q2BRB.Location = new System.Drawing.Point(3, 38);
            this.Q2BRB.Name = "Q2BRB";
            this.Q2BRB.Size = new System.Drawing.Size(521, 19);
            this.Q2BRB.TabIndex = 1;
            this.Q2BRB.TabStop = true;
            this.Q2BRB.Text = "B. -48";
            this.Q2BRB.UseVisualStyleBackColor = true;
            // 
            // Q2ARB
            // 
            this.Q2ARB.AutoSize = true;
            this.Q2ARB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q2ARB.Location = new System.Drawing.Point(3, 19);
            this.Q2ARB.Name = "Q2ARB";
            this.Q2ARB.Size = new System.Drawing.Size(521, 19);
            this.Q2ARB.TabIndex = 0;
            this.Q2ARB.TabStop = true;
            this.Q2ARB.Text = "A. \'-48\'";
            this.Q2ARB.UseVisualStyleBackColor = true;
            // 
            // Q3GB
            // 
            this.Q3GB.Controls.Add(this.Q3DRB);
            this.Q3GB.Controls.Add(this.Q3CRB);
            this.Q3GB.Controls.Add(this.Q3BRB);
            this.Q3GB.Controls.Add(this.Q3ARB);
            this.Q3GB.Location = new System.Drawing.Point(117, 325);
            this.Q3GB.Name = "Q3GB";
            this.Q3GB.Size = new System.Drawing.Size(527, 98);
            this.Q3GB.TabIndex = 5;
            this.Q3GB.TabStop = false;
            this.Q3GB.Text = "var a = [1,2,3,4,5].Aggregate((a, b) => a + b).ToString(); Mikä on a:n arvo?";
            // 
            // Q3DRB
            // 
            this.Q3DRB.AutoSize = true;
            this.Q3DRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q3DRB.Location = new System.Drawing.Point(3, 76);
            this.Q3DRB.Name = "Q3DRB";
            this.Q3DRB.Size = new System.Drawing.Size(521, 19);
            this.Q3DRB.TabIndex = 3;
            this.Q3DRB.TabStop = true;
            this.Q3DRB.Text = "D. 15";
            this.Q3DRB.UseVisualStyleBackColor = true;
            // 
            // Q3CRB
            // 
            this.Q3CRB.AutoSize = true;
            this.Q3CRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q3CRB.Location = new System.Drawing.Point(3, 57);
            this.Q3CRB.Name = "Q3CRB";
            this.Q3CRB.Size = new System.Drawing.Size(521, 19);
            this.Q3CRB.TabIndex = 2;
            this.Q3CRB.TabStop = true;
            this.Q3CRB.Text = "C. [15]";
            this.Q3CRB.UseVisualStyleBackColor = true;
            // 
            // Q3BRB
            // 
            this.Q3BRB.AutoSize = true;
            this.Q3BRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q3BRB.Location = new System.Drawing.Point(3, 38);
            this.Q3BRB.Name = "Q3BRB";
            this.Q3BRB.Size = new System.Drawing.Size(521, 19);
            this.Q3BRB.TabIndex = 1;
            this.Q3BRB.TabStop = true;
            this.Q3BRB.Text = "B. \"15\"";
            this.Q3BRB.UseVisualStyleBackColor = true;
            // 
            // Q3ARB
            // 
            this.Q3ARB.AutoSize = true;
            this.Q3ARB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q3ARB.Location = new System.Drawing.Point(3, 19);
            this.Q3ARB.Name = "Q3ARB";
            this.Q3ARB.Size = new System.Drawing.Size(521, 19);
            this.Q3ARB.TabIndex = 0;
            this.Q3ARB.TabStop = true;
            this.Q3ARB.Text = "A. [\"15\"]";
            this.Q3ARB.UseVisualStyleBackColor = true;
            // 
            // Q4GB
            // 
            this.Q4GB.Controls.Add(this.radioButton1);
            this.Q4GB.Controls.Add(this.radioButton2);
            this.Q4GB.Controls.Add(this.radioButton3);
            this.Q4GB.Controls.Add(this.radioButton4);
            this.Q4GB.Location = new System.Drawing.Point(117, 426);
            this.Q4GB.Name = "Q4GB";
            this.Q4GB.Size = new System.Drawing.Size(527, 98);
            this.Q4GB.TabIndex = 6;
            this.Q4GB.TabStop = false;
            this.Q4GB.Text = "ushort a = 0; a -= 1; Mikä kääntäjävirhe tulostuu konsoliin?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.Location = new System.Drawing.Point(3, 76);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(521, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "D. IndexOutOfBounds";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton2.Location = new System.Drawing.Point(3, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(521, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "C. NullPointer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.Location = new System.Drawing.Point(3, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(521, 19);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "B. IntegerUnderflow";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton4.Location = new System.Drawing.Point(3, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(521, 19);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "A. NullReference";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // ResultLB
            // 
            this.ResultLB.AutoSize = true;
            this.ResultLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLB.Location = new System.Drawing.Point(225, 537);
            this.ResultLB.Name = "ResultLB";
            this.ResultLB.Size = new System.Drawing.Size(68, 30);
            this.ResultLB.TabIndex = 7;
            this.ResultLB.Text = "label1";
            this.ResultLB.Visible = false;
            // 
            // CheckAnswersBT
            // 
            this.CheckAnswersBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckAnswersBT.Location = new System.Drawing.Point(117, 530);
            this.CheckAnswersBT.Name = "CheckAnswersBT";
            this.CheckAnswersBT.Size = new System.Drawing.Size(102, 47);
            this.CheckAnswersBT.TabIndex = 8;
            this.CheckAnswersBT.Text = "Tarkista";
            this.CheckAnswersBT.UseVisualStyleBackColor = true;
            this.CheckAnswersBT.Click += new System.EventHandler(this.CheckAnswersBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 613);
            this.Controls.Add(this.CheckAnswersBT);
            this.Controls.Add(this.ResultLB);
            this.Controls.Add(this.Q4GB);
            this.Controls.Add(this.Q3GB);
            this.Controls.Add(this.Q2GB);
            this.Controls.Add(this.Q1GB);
            this.Controls.Add(this.SubheaderLB);
            this.Controls.Add(this.HeaderLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Q1GB.ResumeLayout(false);
            this.Q1GB.PerformLayout();
            this.Q2GB.ResumeLayout(false);
            this.Q2GB.PerformLayout();
            this.Q3GB.ResumeLayout(false);
            this.Q3GB.PerformLayout();
            this.Q4GB.ResumeLayout(false);
            this.Q4GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLB;
        private Label SubheaderLB;
        private GroupBox Q1GB;
        private RadioButton Q1DRB;
        private RadioButton Q1CRB;
        private RadioButton Q1BRB;
        private RadioButton Q1ARB;
        private GroupBox Q2GB;
        private RadioButton Q2DRB;
        private RadioButton Q2CRB;
        private RadioButton Q2BRB;
        private RadioButton Q2ARB;
        private GroupBox Q3GB;
        private RadioButton Q3DRB;
        private RadioButton Q3CRB;
        private RadioButton Q3BRB;
        private RadioButton Q3ARB;
        private GroupBox Q4GB;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label ResultLB;
        private Button CheckAnswersBT;
    }
}