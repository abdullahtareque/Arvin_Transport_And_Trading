namespace Arvin_Transport_And_Trading.Forms
{
    partial class FormCustomer
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.customerTblTableAdapter = new Arvin_Transport_And_Trading.ArvinTransportDBDataSet5TableAdapters.CustomerTblTableAdapter();
            this.txtimage = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.arvinTransportDBDataSet6 = new Arvin_Transport_And_Trading.ArvinTransportDBDataSet6();
            this.customerTblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.customerTblTableAdapter1 = new Arvin_Transport_And_Trading.ArvinTransportDBDataSet6TableAdapters.CustomerTblTableAdapter();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTblBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.arvinTransportDBDataSet8 = new Arvin_Transport_And_Trading.ArvinTransportDBDataSet8();
            this.customerTblTableAdapter2 = new Arvin_Transport_And_Trading.ArvinTransportDBDataSet7TableAdapters.CustomerTblTableAdapter();
            this.customerTblTableAdapter3 = new Arvin_Transport_And_Trading.ArvinTransportDBDataSet8TableAdapters.CustomerTblTableAdapter();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.customerTblBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.arvinTransportDBDataSet7 = new Arvin_Transport_And_Trading.ArvinTransportDBDataSet7();
            this.customerTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arvinTransportDBDataSet5 = new Arvin_Transport_And_Trading.ArvinTransportDBDataSet5();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arvinTransportDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arvinTransportDBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arvinTransportDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arvinTransportDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 91;
            this.label6.Text = "Id";
            // 
            // btnADD
            // 
            this.btnADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Location = new System.Drawing.Point(738, 567);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(115, 46);
            this.btnADD.TabIndex = 78;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // customerTblTableAdapter
            // 
            this.customerTblTableAdapter.ClearBeforeFill = true;
            // 
            // txtimage
            // 
            this.txtimage.Location = new System.Drawing.Point(123, 84);
            this.txtimage.Multiline = true;
            this.txtimage.Name = "txtimage";
            this.txtimage.Size = new System.Drawing.Size(87, 26);
            this.txtimage.TabIndex = 94;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(231, 35);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 31);
            this.btnUpload.TabIndex = 93;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 92;
            this.label7.Text = "Pic";
            // 
            // arvinTransportDBDataSet6
            // 
            this.arvinTransportDBDataSet6.DataSetName = "ArvinTransportDBDataSet6";
            this.arvinTransportDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTblBindingSource2
            // 
            this.customerTblBindingSource2.DataMember = "CustomerTbl";
            this.customerTblBindingSource2.DataSource = this.arvinTransportDBDataSet6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(123, 116);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(174, 26);
            this.textBoxId.TabIndex = 74;
            // 
            // customerTblTableAdapter1
            // 
            this.customerTblTableAdapter1.ClearBeforeFill = true;
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCustomer.AutoGenerateColumns = false;
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.imageDataGridViewTextBoxColumn});
            this.DGVCustomer.DataSource = this.customerTblBindingSource4;
            this.DGVCustomer.Location = new System.Drawing.Point(339, 76);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.RowHeadersWidth = 62;
            this.DGVCustomer.RowTemplate.Height = 28;
            this.DGVCustomer.Size = new System.Drawing.Size(812, 480);
            this.DGVCustomer.TabIndex = 95;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustAddress";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerTblBindingSource4
            // 
            this.customerTblBindingSource4.DataMember = "CustomerTbl";
            this.customerTblBindingSource4.DataSource = this.arvinTransportDBDataSet8;
            // 
            // arvinTransportDBDataSet8
            // 
            this.arvinTransportDBDataSet8.DataSetName = "ArvinTransportDBDataSet8";
            this.arvinTransportDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTblTableAdapter2
            // 
            this.customerTblTableAdapter2.ClearBeforeFill = true;
            // 
            // customerTblTableAdapter3
            // 
            this.customerTblTableAdapter3.ClearBeforeFill = true;
            // 
            // btnEDIT
            // 
            this.btnEDIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.Location = new System.Drawing.Point(887, 567);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(115, 46);
            this.btnEDIT.TabIndex = 79;
            this.btnEDIT.Text = "UPDATE";
            this.btnEDIT.UseVisualStyleBackColor = true;
            // 
            // btnDELETE
            // 
            this.btnDELETE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Location = new System.Drawing.Point(1036, 567);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(115, 46);
            this.btnDELETE.TabIndex = 80;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            // 
            // customerTblBindingSource3
            // 
            this.customerTblBindingSource3.DataMember = "CustomerTbl";
            this.customerTblBindingSource3.DataSource = this.arvinTransportDBDataSet7;
            // 
            // arvinTransportDBDataSet7
            // 
            this.arvinTransportDBDataSet7.DataSetName = "ArvinTransportDBDataSet7";
            this.arvinTransportDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTblBindingSource1
            // 
            this.customerTblBindingSource1.DataMember = "CustomerTbl";
            // 
            // customerTblBindingSource
            // 
            this.customerTblBindingSource.DataMember = "CustomerTbl";
            this.customerTblBindingSource.DataSource = this.arvinTransportDBDataSet5;
            // 
            // arvinTransportDBDataSet5
            // 
            this.arvinTransportDBDataSet5.DataSetName = "ArvinTransportDBDataSet5";
            this.arvinTransportDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox.Location = new System.Drawing.Point(123, 18);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(87, 60);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 90;
            this.pictureBox.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 406);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 89;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 88;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(97, 341);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 87;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(97, 311);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 86;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 85;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(682, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 84;
            this.label4.Text = "Customer List";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(123, 238);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(174, 26);
            this.textBoxPhone.TabIndex = 77;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(123, 198);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(174, 26);
            this.textBoxAddress.TabIndex = 76;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(123, 155);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 26);
            this.textBoxName.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "Name";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 630);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtimage);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.DGVCustomer);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arvinTransportDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arvinTransportDBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arvinTransportDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arvinTransportDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnADD;
        private ArvinTransportDBDataSet5TableAdapters.CustomerTblTableAdapter customerTblTableAdapter;
        private System.Windows.Forms.TextBox txtimage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label7;
        private ArvinTransportDBDataSet6 arvinTransportDBDataSet6;
        private System.Windows.Forms.BindingSource customerTblBindingSource2;
        private System.Windows.Forms.TextBox textBoxId;
        private ArvinTransportDBDataSet6TableAdapters.CustomerTblTableAdapter customerTblTableAdapter1;
        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerTblBindingSource4;
        private ArvinTransportDBDataSet8 arvinTransportDBDataSet8;
        private ArvinTransportDBDataSet7TableAdapters.CustomerTblTableAdapter customerTblTableAdapter2;
        private ArvinTransportDBDataSet8TableAdapters.CustomerTblTableAdapter customerTblTableAdapter3;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.BindingSource customerTblBindingSource3;
        private ArvinTransportDBDataSet7 arvinTransportDBDataSet7;
        private System.Windows.Forms.BindingSource customerTblBindingSource1;
        private System.Windows.Forms.BindingSource customerTblBindingSource;
        private ArvinTransportDBDataSet5 arvinTransportDBDataSet5;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}