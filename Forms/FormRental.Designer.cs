namespace Arvin_Transport_And_Trading.Forms
{
    partial class FormRental
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
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.RentDGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCarReg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxFees = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.comboBoxCustId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnDate
            // 
            this.ReturnDate.CalendarForeColor = System.Drawing.Color.White;
            this.ReturnDate.CalendarMonthBackground = System.Drawing.Color.Green;
            this.ReturnDate.Checked = false;
            this.ReturnDate.Location = new System.Drawing.Point(140, 328);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(175, 26);
            this.ReturnDate.TabIndex = 66;
            // 
            // RentDGV
            // 
            this.RentDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentDGV.Location = new System.Drawing.Point(339, 64);
            this.RentDGV.Name = "RentDGV";
            this.RentDGV.RowHeadersWidth = 62;
            this.RentDGV.RowTemplate.Height = 28;
            this.RentDGV.Size = new System.Drawing.Size(413, 300);
            this.RentDGV.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "label4";
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Enabled = false;
            this.textBoxCustName.Location = new System.Drawing.Point(140, 197);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(175, 26);
            this.textBoxCustName.TabIndex = 59;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(140, 67);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(175, 26);
            this.textBoxId.TabIndex = 57;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 205);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 20);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "CustName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "CarReg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Id";
            // 
            // comboBoxCarReg
            // 
            this.comboBoxCarReg.FormattingEnabled = true;
            this.comboBoxCarReg.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxCarReg.Location = new System.Drawing.Point(140, 110);
            this.comboBoxCarReg.Name = "comboBoxCarReg";
            this.comboBoxCarReg.Size = new System.Drawing.Size(175, 28);
            this.comboBoxCarReg.TabIndex = 83;
            this.comboBoxCarReg.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarReg_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "CustId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "Return Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "Rental Date";
            // 
            // RentDate
            // 
            this.RentDate.CalendarForeColor = System.Drawing.Color.White;
            this.RentDate.CalendarMonthBackground = System.Drawing.Color.Green;
            this.RentDate.Checked = false;
            this.RentDate.Location = new System.Drawing.Point(140, 280);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(175, 26);
            this.RentDate.TabIndex = 87;
            // 
            // textBoxFees
            // 
            this.textBoxFees.Location = new System.Drawing.Point(140, 375);
            this.textBoxFees.Name = "textBoxFees";
            this.textBoxFees.Size = new System.Drawing.Size(175, 26);
            this.textBoxFees.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 89;
            this.label8.Text = "Fees";
            // 
            // btnADD
            // 
            this.btnADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Location = new System.Drawing.Point(339, 379);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(115, 46);
            this.btnADD.TabIndex = 93;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.Location = new System.Drawing.Point(488, 379);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(115, 46);
            this.btnEDIT.TabIndex = 92;
            this.btnEDIT.Text = "UPDATE";
            this.btnEDIT.UseVisualStyleBackColor = true;
            // 
            // btnDELETE
            // 
            this.btnDELETE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Location = new System.Drawing.Point(637, 379);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(115, 46);
            this.btnDELETE.TabIndex = 91;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            // 
            // comboBoxCustId
            // 
            this.comboBoxCustId.FormattingEnabled = true;
            this.comboBoxCustId.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxCustId.Location = new System.Drawing.Point(140, 155);
            this.comboBoxCustId.Name = "comboBoxCustId";
            this.comboBoxCustId.Size = new System.Drawing.Size(175, 28);
            this.comboBoxCustId.TabIndex = 94;
            this.comboBoxCustId.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCustId_SelectionChangeCommitted);
            // 
            // FormRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCustId);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.textBoxFees);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCarReg);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.RentDGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCustName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRental";
            this.Text = "FormRental";
            this.Load += new System.EventHandler(this.FormRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.DataGridView RentDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCarReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.TextBox textBoxFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.ComboBox comboBoxCustId;
    }
}