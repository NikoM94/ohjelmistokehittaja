namespace Hotelli
{
    partial class HotelReservationFM
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
            this.ReservationEmptyFieldsBT = new System.Windows.Forms.Button();
            this.ReservationDeleteBT = new System.Windows.Forms.Button();
            this.ReservationAddBT = new System.Windows.Forms.Button();
            this.ReservationUpdateBT = new System.Windows.Forms.Button();
            this.ReservationNumberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReservationCustomerNumberCB = new System.Windows.Forms.ComboBox();
            this.ReservationRoomTypeCB = new System.Windows.Forms.ComboBox();
            this.ReservationRoomNumberCB = new System.Windows.Forms.ComboBox();
            this.ReservationInDTP = new System.Windows.Forms.DateTimePicker();
            this.ReservationOutDTP = new System.Windows.Forms.DateTimePicker();
            this.ReservationDG = new System.Windows.Forms.DataGridView();
            this.ReservationManagementLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReservationEmptyFieldsBT
            // 
            this.ReservationEmptyFieldsBT.Location = new System.Drawing.Point(56, 366);
            this.ReservationEmptyFieldsBT.Name = "ReservationEmptyFieldsBT";
            this.ReservationEmptyFieldsBT.Size = new System.Drawing.Size(235, 23);
            this.ReservationEmptyFieldsBT.TabIndex = 37;
            this.ReservationEmptyFieldsBT.Text = "Tyhjennä kentät";
            this.ReservationEmptyFieldsBT.UseVisualStyleBackColor = true;
            this.ReservationEmptyFieldsBT.Click += new System.EventHandler(this.ReservationEmptyFieldsBT_Click);
            // 
            // ReservationDeleteBT
            // 
            this.ReservationDeleteBT.Location = new System.Drawing.Point(220, 337);
            this.ReservationDeleteBT.Name = "ReservationDeleteBT";
            this.ReservationDeleteBT.Size = new System.Drawing.Size(71, 23);
            this.ReservationDeleteBT.TabIndex = 36;
            this.ReservationDeleteBT.Text = "Poista";
            this.ReservationDeleteBT.UseVisualStyleBackColor = true;
            this.ReservationDeleteBT.Click += new System.EventHandler(this.ReservationDeleteBT_Click);
            // 
            // ReservationAddBT
            // 
            this.ReservationAddBT.Location = new System.Drawing.Point(56, 337);
            this.ReservationAddBT.Name = "ReservationAddBT";
            this.ReservationAddBT.Size = new System.Drawing.Size(76, 23);
            this.ReservationAddBT.TabIndex = 35;
            this.ReservationAddBT.Text = "Lisää";
            this.ReservationAddBT.UseVisualStyleBackColor = true;
            this.ReservationAddBT.Click += new System.EventHandler(this.ReservationAddBT_Click);
            // 
            // ReservationUpdateBT
            // 
            this.ReservationUpdateBT.Location = new System.Drawing.Point(138, 337);
            this.ReservationUpdateBT.Name = "ReservationUpdateBT";
            this.ReservationUpdateBT.Size = new System.Drawing.Size(76, 23);
            this.ReservationUpdateBT.TabIndex = 34;
            this.ReservationUpdateBT.Text = "Muokkaa";
            this.ReservationUpdateBT.UseVisualStyleBackColor = true;
            this.ReservationUpdateBT.Click += new System.EventHandler(this.ReservationUpdateBT_Click);
            // 
            // ReservationNumberTB
            // 
            this.ReservationNumberTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReservationNumberTB.Location = new System.Drawing.Point(149, 160);
            this.ReservationNumberTB.Name = "ReservationNumberTB";
            this.ReservationNumberTB.Size = new System.Drawing.Size(142, 23);
            this.ReservationNumberTB.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Huoneen nro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "Huonetyyppi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Asiakas nro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Varaus nro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(85, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 30);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ulos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(66, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 30);
            this.label6.TabIndex = 38;
            this.label6.Text = "Sisään:";
            // 
            // ReservationCustomerNumberCB
            // 
            this.ReservationCustomerNumberCB.FormattingEnabled = true;
            this.ReservationCustomerNumberCB.Location = new System.Drawing.Point(149, 189);
            this.ReservationCustomerNumberCB.Name = "ReservationCustomerNumberCB";
            this.ReservationCustomerNumberCB.Size = new System.Drawing.Size(142, 23);
            this.ReservationCustomerNumberCB.TabIndex = 40;
            // 
            // ReservationRoomTypeCB
            // 
            this.ReservationRoomTypeCB.FormattingEnabled = true;
            this.ReservationRoomTypeCB.Location = new System.Drawing.Point(149, 221);
            this.ReservationRoomTypeCB.Name = "ReservationRoomTypeCB";
            this.ReservationRoomTypeCB.Size = new System.Drawing.Size(142, 23);
            this.ReservationRoomTypeCB.TabIndex = 41;
            // 
            // ReservationRoomNumberCB
            // 
            this.ReservationRoomNumberCB.FormattingEnabled = true;
            this.ReservationRoomNumberCB.Location = new System.Drawing.Point(149, 251);
            this.ReservationRoomNumberCB.Name = "ReservationRoomNumberCB";
            this.ReservationRoomNumberCB.Size = new System.Drawing.Size(142, 23);
            this.ReservationRoomNumberCB.TabIndex = 42;
            // 
            // ReservationInDTP
            // 
            this.ReservationInDTP.CustomFormat = "dd/MM/yyyy";
            this.ReservationInDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReservationInDTP.Location = new System.Drawing.Point(149, 281);
            this.ReservationInDTP.Name = "ReservationInDTP";
            this.ReservationInDTP.Size = new System.Drawing.Size(142, 23);
            this.ReservationInDTP.TabIndex = 43;
            // 
            // ReservationOutDTP
            // 
            this.ReservationOutDTP.CustomFormat = "dd/MM/yyyy";
            this.ReservationOutDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReservationOutDTP.Location = new System.Drawing.Point(149, 311);
            this.ReservationOutDTP.Name = "ReservationOutDTP";
            this.ReservationOutDTP.Size = new System.Drawing.Size(142, 23);
            this.ReservationOutDTP.TabIndex = 44;
            // 
            // ReservationDG
            // 
            this.ReservationDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationDG.Location = new System.Drawing.Point(307, 107);
            this.ReservationDG.Name = "ReservationDG";
            this.ReservationDG.RowTemplate.Height = 25;
            this.ReservationDG.Size = new System.Drawing.Size(530, 351);
            this.ReservationDG.TabIndex = 46;
            // 
            // ReservationManagementLB
            // 
            this.ReservationManagementLB.AutoSize = true;
            this.ReservationManagementLB.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReservationManagementLB.Location = new System.Drawing.Point(242, 23);
            this.ReservationManagementLB.Name = "ReservationManagementLB";
            this.ReservationManagementLB.Size = new System.Drawing.Size(313, 50);
            this.ReservationManagementLB.TabIndex = 0;
            this.ReservationManagementLB.Text = "Varausten hallinta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ReservationManagementLB);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 100);
            this.panel1.TabIndex = 45;
            // 
            // HotelReservationFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 459);
            this.Controls.Add(this.ReservationDG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReservationOutDTP);
            this.Controls.Add(this.ReservationInDTP);
            this.Controls.Add(this.ReservationRoomNumberCB);
            this.Controls.Add(this.ReservationRoomTypeCB);
            this.Controls.Add(this.ReservationCustomerNumberCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReservationEmptyFieldsBT);
            this.Controls.Add(this.ReservationDeleteBT);
            this.Controls.Add(this.ReservationAddBT);
            this.Controls.Add(this.ReservationUpdateBT);
            this.Controls.Add(this.ReservationNumberTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HotelReservationFM";
            this.Text = "Varausten hallinta";
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ReservationEmptyFieldsBT;
        private Button ReservationDeleteBT;
        private Button ReservationAddBT;
        private Button ReservationUpdateBT;
        private TextBox ReservationNumberTB;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private ComboBox ReservationCustomerNumberCB;
        private ComboBox ReservationRoomTypeCB;
        private ComboBox ReservationRoomNumberCB;
        private DateTimePicker ReservationInDTP;
        private DateTimePicker ReservationOutDTP;
        private DataGridView ReservationDG;
        private Label ReservationManagementLB;
        private Panel panel1;
    }
}