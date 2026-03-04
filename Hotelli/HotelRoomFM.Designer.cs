namespace Hotelli
{
    partial class HotelRoomFM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RoomDG = new System.Windows.Forms.DataGridView();
            this.ReservationManagementLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoomEmptyFieldsBT = new System.Windows.Forms.Button();
            this.RoomDeleteBT = new System.Windows.Forms.Button();
            this.RoomAddBT = new System.Windows.Forms.Button();
            this.RoomUpdateBT = new System.Windows.Forms.Button();
            this.RoomPhoneTB = new System.Windows.Forms.TextBox();
            this.RoomRoomNumberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomRoomTypeCB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RoomFreeNoRB = new System.Windows.Forms.RadioButton();
            this.RoomFreeYesRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomDG
            // 
            this.RoomDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomDG.Location = new System.Drawing.Point(307, 107);
            this.RoomDG.Name = "RoomDG";
            this.RoomDG.RowTemplate.Height = 25;
            this.RoomDG.Size = new System.Drawing.Size(530, 351);
            this.RoomDG.TabIndex = 48;
            this.RoomDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomDG_CellClick);
            // 
            // ReservationManagementLB
            // 
            this.ReservationManagementLB.AutoSize = true;
            this.ReservationManagementLB.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReservationManagementLB.Location = new System.Drawing.Point(242, 23);
            this.ReservationManagementLB.Name = "ReservationManagementLB";
            this.ReservationManagementLB.Size = new System.Drawing.Size(332, 50);
            this.ReservationManagementLB.TabIndex = 0;
            this.ReservationManagementLB.Text = "Huoneiden hallinta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ReservationManagementLB);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 100);
            this.panel1.TabIndex = 47;
            // 
            // RoomEmptyFieldsBT
            // 
            this.RoomEmptyFieldsBT.Location = new System.Drawing.Point(67, 368);
            this.RoomEmptyFieldsBT.Name = "RoomEmptyFieldsBT";
            this.RoomEmptyFieldsBT.Size = new System.Drawing.Size(235, 23);
            this.RoomEmptyFieldsBT.TabIndex = 66;
            this.RoomEmptyFieldsBT.Text = "Tyhjennä kentät";
            this.RoomEmptyFieldsBT.UseVisualStyleBackColor = true;
            this.RoomEmptyFieldsBT.Click += new System.EventHandler(this.RoomEmptyFieldsBT_Click);
            // 
            // RoomDeleteBT
            // 
            this.RoomDeleteBT.Location = new System.Drawing.Point(231, 339);
            this.RoomDeleteBT.Name = "RoomDeleteBT";
            this.RoomDeleteBT.Size = new System.Drawing.Size(71, 23);
            this.RoomDeleteBT.TabIndex = 65;
            this.RoomDeleteBT.Text = "Poista";
            this.RoomDeleteBT.UseVisualStyleBackColor = true;
            this.RoomDeleteBT.Click += new System.EventHandler(this.RoomDeleteBT_Click);
            // 
            // RoomAddBT
            // 
            this.RoomAddBT.Location = new System.Drawing.Point(67, 339);
            this.RoomAddBT.Name = "RoomAddBT";
            this.RoomAddBT.Size = new System.Drawing.Size(76, 23);
            this.RoomAddBT.TabIndex = 64;
            this.RoomAddBT.Text = "Lisää";
            this.RoomAddBT.UseVisualStyleBackColor = true;
            this.RoomAddBT.Click += new System.EventHandler(this.RoomAddBT_Click);
            // 
            // RoomUpdateBT
            // 
            this.RoomUpdateBT.Location = new System.Drawing.Point(149, 339);
            this.RoomUpdateBT.Name = "RoomUpdateBT";
            this.RoomUpdateBT.Size = new System.Drawing.Size(76, 23);
            this.RoomUpdateBT.TabIndex = 63;
            this.RoomUpdateBT.Text = "Muokkaa";
            this.RoomUpdateBT.UseVisualStyleBackColor = true;
            this.RoomUpdateBT.Click += new System.EventHandler(this.RoomUpdateBT_Click);
            // 
            // RoomPhoneTB
            // 
            this.RoomPhoneTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomPhoneTB.Location = new System.Drawing.Point(160, 271);
            this.RoomPhoneTB.Name = "RoomPhoneTB";
            this.RoomPhoneTB.Size = new System.Drawing.Size(142, 23);
            this.RoomPhoneTB.TabIndex = 58;
            // 
            // RoomRoomNumberTB
            // 
            this.RoomRoomNumberTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomRoomNumberTB.Location = new System.Drawing.Point(160, 210);
            this.RoomRoomNumberTB.Name = "RoomRoomNumberTB";
            this.RoomRoomNumberTB.Size = new System.Drawing.Size(142, 23);
            this.RoomRoomNumberTB.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 52;
            this.label3.Text = "Vapaa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 30);
            this.label4.TabIndex = 51;
            this.label4.Text = "Puhelin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 50;
            this.label2.Text = "Huonetyyppi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 49;
            this.label1.Text = "Huoneen nro:";
            // 
            // RoomRoomTypeCB
            // 
            this.RoomRoomTypeCB.FormattingEnabled = true;
            this.RoomRoomTypeCB.Location = new System.Drawing.Point(160, 241);
            this.RoomRoomTypeCB.Name = "RoomRoomTypeCB";
            this.RoomRoomTypeCB.Size = new System.Drawing.Size(142, 23);
            this.RoomRoomTypeCB.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.RoomFreeNoRB);
            this.panel2.Controls.Add(this.RoomFreeYesRB);
            this.panel2.Location = new System.Drawing.Point(160, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 32);
            this.panel2.TabIndex = 68;
            // 
            // RoomFreeNoRB
            // 
            this.RoomFreeNoRB.AutoSize = true;
            this.RoomFreeNoRB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoomFreeNoRB.ForeColor = System.Drawing.Color.Brown;
            this.RoomFreeNoRB.Location = new System.Drawing.Point(83, 6);
            this.RoomFreeNoRB.Name = "RoomFreeNoRB";
            this.RoomFreeNoRB.Size = new System.Drawing.Size(35, 19);
            this.RoomFreeNoRB.TabIndex = 1;
            this.RoomFreeNoRB.TabStop = true;
            this.RoomFreeNoRB.Text = "EI";
            this.RoomFreeNoRB.UseVisualStyleBackColor = true;
            this.RoomFreeNoRB.CheckedChanged += new System.EventHandler(this.RoomFreeNoRB_CheckedChanged);
            // 
            // RoomFreeYesRB
            // 
            this.RoomFreeYesRB.AutoSize = true;
            this.RoomFreeYesRB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoomFreeYesRB.ForeColor = System.Drawing.Color.ForestGreen;
            this.RoomFreeYesRB.Location = new System.Drawing.Point(17, 6);
            this.RoomFreeYesRB.Name = "RoomFreeYesRB";
            this.RoomFreeYesRB.Size = new System.Drawing.Size(60, 19);
            this.RoomFreeYesRB.TabIndex = 0;
            this.RoomFreeYesRB.TabStop = true;
            this.RoomFreeYesRB.Text = "KYLLÄ";
            this.RoomFreeYesRB.UseVisualStyleBackColor = true;
            this.RoomFreeYesRB.CheckedChanged += new System.EventHandler(this.RoomFreeYesRB_CheckedChanged);
            // 
            // HotelRoomFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RoomRoomTypeCB);
            this.Controls.Add(this.RoomEmptyFieldsBT);
            this.Controls.Add(this.RoomDeleteBT);
            this.Controls.Add(this.RoomAddBT);
            this.Controls.Add(this.RoomUpdateBT);
            this.Controls.Add(this.RoomPhoneTB);
            this.Controls.Add(this.RoomRoomNumberTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomDG);
            this.Controls.Add(this.panel1);
            this.Name = "HotelRoomFM";
            this.Text = "Huoneiden hallinta";
            this.Load += new System.EventHandler(this.HotelRoomFM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView RoomDG;
        private Label ReservationManagementLB;
        private Panel panel1;
        private Button RoomEmptyFieldsBT;
        private Button RoomDeleteBT;
        private Button RoomAddBT;
        private Button RoomUpdateBT;
        private TextBox RoomPhoneTB;
        private TextBox RoomRoomNumberTB;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox RoomRoomTypeCB;
        private Panel panel2;
        private RadioButton RoomFreeNoRB;
        private RadioButton RoomFreeYesRB;
    }
}