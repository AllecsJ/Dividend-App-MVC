namespace BaritaDividendsApp
{
    partial class newDividends
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.approveBtn = new System.Windows.Forms.Button();
            this.f2linkLabel = new System.Windows.Forms.LinkLabel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.dividends_DBDataSet = new BaritaDividendsApp.Dividends_DBDataSet();
            this.dividendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dividendsTableAdapter = new BaritaDividendsApp.Dividends_DBDataSetTableAdapters.dividendsTableAdapter();
            this.tableAdapterManager = new BaritaDividendsApp.Dividends_DBDataSetTableAdapters.TableAdapterManager();
            this.status_codesTableAdapter = new BaritaDividendsApp.Dividends_DBDataSetTableAdapters.status_codesTableAdapter();
            this.status_codesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securitiesTableAdapter1 = new BaritaDividendsApp.Dividends_DBDataSetTableAdapters.securitiesTableAdapter();
            this.securityComboBox = new System.Windows.Forms.ComboBox();
            this.securityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dividends_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_codesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Date";
            // 
            // paymentDateTimePicker
            // 
            this.paymentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paymentDateTimePicker.Location = new System.Drawing.Point(190, 229);
            this.paymentDateTimePicker.Name = "paymentDateTimePicker";
            this.paymentDateTimePicker.Size = new System.Drawing.Size(470, 20);
            this.paymentDateTimePicker.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(190, 305);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(585, 305);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(453, 305);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // approveBtn
            // 
            this.approveBtn.Location = new System.Drawing.Point(323, 305);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(75, 23);
            this.approveBtn.TabIndex = 7;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = true;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // f2linkLabel
            // 
            this.f2linkLabel.AutoSize = true;
            this.f2linkLabel.Location = new System.Drawing.Point(360, 99);
            this.f2linkLabel.Name = "f2linkLabel";
            this.f2linkLabel.Size = new System.Drawing.Size(109, 13);
            this.f2linkLabel.TabIndex = 8;
            this.f2linkLabel.TabStop = true;
            this.f2linkLabel.Text = "Go to View Dividends";
            this.f2linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.f2linkLabel_LinkClicked);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(585, 352);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // dividends_DBDataSet
            // 
            this.dividends_DBDataSet.DataSetName = "Dividends_DBDataSet";
            this.dividends_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dividendsBindingSource
            // 
            this.dividendsBindingSource.DataMember = "dividends";
            this.dividendsBindingSource.DataSource = this.dividends_DBDataSet;
            // 
            // dividendsTableAdapter
            // 
            this.dividendsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dividendsTableAdapter = this.dividendsTableAdapter;
            this.tableAdapterManager.securitiesTableAdapter = null;
            this.tableAdapterManager.status_codesTableAdapter = this.status_codesTableAdapter;
            this.tableAdapterManager.UpdateOrder = BaritaDividendsApp.Dividends_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // status_codesTableAdapter
            // 
            this.status_codesTableAdapter.ClearBeforeFill = true;
            // 
            // status_codesBindingSource
            // 
            this.status_codesBindingSource.DataMember = "status_codes";
            this.status_codesBindingSource.DataSource = this.dividends_DBDataSet;
            // 
            // securitiesTableAdapter1
            // 
            this.securitiesTableAdapter1.ClearBeforeFill = true;
            // 
            // securityComboBox
            // 
            this.securityComboBox.FormattingEnabled = true;
            this.securityComboBox.Location = new System.Drawing.Point(190, 162);
            this.securityComboBox.Name = "securityComboBox";
            this.securityComboBox.Size = new System.Drawing.Size(466, 21);
            this.securityComboBox.TabIndex = 14;
            this.securityComboBox.SelectedIndexChanged += new System.EventHandler(this.securityComboBox_SelectedIndexChanged);
            // 
            // securityLabel
            // 
            this.securityLabel.AutoSize = true;
            this.securityLabel.Location = new System.Drawing.Point(244, 274);
            this.securityLabel.Name = "securityLabel";
            this.securityLabel.Size = new System.Drawing.Size(35, 13);
            this.securityLabel.TabIndex = 15;
            this.securityLabel.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Security:";
            // 
            // newDividends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(939, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.securityLabel);
            this.Controls.Add(this.securityComboBox);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.f2linkLabel);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.paymentDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newDividends";
            this.Text = "New Dividend";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dividends_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_codesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker paymentDateTimePicker;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.LinkLabel f2linkLabel;
        private System.Windows.Forms.Button CloseBtn;
        private Dividends_DBDataSet dividends_DBDataSet;
        private System.Windows.Forms.BindingSource dividendsBindingSource;
        private Dividends_DBDataSetTableAdapters.dividendsTableAdapter dividendsTableAdapter;
        private Dividends_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Dividends_DBDataSetTableAdapters.status_codesTableAdapter status_codesTableAdapter;
        private System.Windows.Forms.BindingSource status_codesBindingSource;
        private Dividends_DBDataSetTableAdapters.securitiesTableAdapter securitiesTableAdapter1;
        private System.Windows.Forms.ComboBox securityComboBox;
        private System.Windows.Forms.Label securityLabel;
        private System.Windows.Forms.Label label3;
    }
}