namespace Ajastin
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
            this.components = new System.ComponentModel.Container();
            this.MinutesLB = new System.Windows.Forms.Label();
            this.SecondsLB = new System.Windows.Forms.Label();
            this.MinutesCB = new System.Windows.Forms.ComboBox();
            this.SecondsCB = new System.Windows.Forms.ComboBox();
            this.TimerLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MinutesLB
            // 
            this.MinutesLB.AutoSize = true;
            this.MinutesLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinutesLB.Location = new System.Drawing.Point(30, 23);
            this.MinutesLB.Name = "MinutesLB";
            this.MinutesLB.Size = new System.Drawing.Size(88, 25);
            this.MinutesLB.TabIndex = 0;
            this.MinutesLB.Text = "Minuutit:";
            this.MinutesLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // SecondsLB
            // 
            this.SecondsLB.AutoSize = true;
            this.SecondsLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondsLB.Location = new System.Drawing.Point(124, 23);
            this.SecondsLB.Name = "SecondsLB";
            this.SecondsLB.Size = new System.Drawing.Size(89, 25);
            this.SecondsLB.TabIndex = 1;
            this.SecondsLB.Text = "Sekunnit:";
            // 
            // MinutesCB
            // 
            this.MinutesCB.FormattingEnabled = true;
            this.MinutesCB.Location = new System.Drawing.Point(30, 51);
            this.MinutesCB.Name = "MinutesCB";
            this.MinutesCB.Size = new System.Drawing.Size(88, 23);
            this.MinutesCB.TabIndex = 2;
            // 
            // SecondsCB
            // 
            this.SecondsCB.FormattingEnabled = true;
            this.SecondsCB.Location = new System.Drawing.Point(125, 51);
            this.SecondsCB.Name = "SecondsCB";
            this.SecondsCB.Size = new System.Drawing.Size(88, 23);
            this.SecondsCB.TabIndex = 3;
            // 
            // TimerLB
            // 
            this.TimerLB.AutoSize = true;
            this.TimerLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLB.Location = new System.Drawing.Point(30, 77);
            this.TimerLB.Name = "TimerLB";
            this.TimerLB.Size = new System.Drawing.Size(191, 86);
            this.TimerLB.TabIndex = 4;
            this.TimerLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBT.Location = new System.Drawing.Point(32, 166);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(86, 47);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopBT.Location = new System.Drawing.Point(125, 166);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(86, 47);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 246);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimerLB);
            this.Controls.Add(this.SecondsCB);
            this.Controls.Add(this.MinutesCB);
            this.Controls.Add(this.SecondsLB);
            this.Controls.Add(this.MinutesLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MinutesLB;
        private Label SecondsLB;
        private ComboBox MinutesCB;
        private ComboBox SecondsCB;
        private Label TimerLB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer timer1;
    }
}