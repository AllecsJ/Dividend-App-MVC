namespace BaritaDividendsApp
{
    partial class viewDividends
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dividendDataGrid = new System.Windows.Forms.DataGridView();
            this.closebtn1 = new System.Windows.Forms.Button();
            this.securityComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.editLabel = new System.Windows.Forms.LinkLabel();
            this.DeleteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.approveLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cancelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dividendDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Dividends";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Security";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(574, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to New Dividend Screen";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(87, 157);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 7;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(87, 204);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(212, 286);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dividendDataGrid
            // 
            this.dividendDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dividendDataGrid.Location = new System.Drawing.Point(341, 52);
            this.dividendDataGrid.Name = "dividendDataGrid";
            this.dividendDataGrid.Size = new System.Drawing.Size(586, 226);
            this.dividendDataGrid.TabIndex = 13;
            this.dividendDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dividendDataGrid_CellContentClick);
            // 
            // closebtn1
            // 
            this.closebtn1.Location = new System.Drawing.Point(852, 352);
            this.closebtn1.Name = "closebtn1";
            this.closebtn1.Size = new System.Drawing.Size(75, 23);
            this.closebtn1.TabIndex = 14;
            this.closebtn1.Text = "Close";
            this.closebtn1.UseVisualStyleBackColor = true;
            this.closebtn1.Click += new System.EventHandler(this.closebtn1_Click);
            // 
            // securityComboBox
            // 
            this.securityComboBox.FormattingEnabled = true;
            this.securityComboBox.Location = new System.Drawing.Point(87, 97);
            this.securityComboBox.Name = "securityComboBox";
            this.securityComboBox.Size = new System.Drawing.Size(200, 21);
            this.securityComboBox.TabIndex = 15;
            this.securityComboBox.SelectedIndexChanged += new System.EventHandler(this.securityComboBox_SelectedIndexChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(87, 255);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 21);
            this.statusComboBox.TabIndex = 16;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(406, 319);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(25, 13);
            this.editLabel.TabIndex = 17;
            this.editLabel.TabStop = true;
            this.editLabel.Text = "Edit";
            this.editLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editLabel_LinkClicked);
            // 
            // DeleteLinkLabel
            // 
            this.DeleteLinkLabel.AutoSize = true;
            this.DeleteLinkLabel.Location = new System.Drawing.Point(544, 319);
            this.DeleteLinkLabel.Name = "DeleteLinkLabel";
            this.DeleteLinkLabel.Size = new System.Drawing.Size(38, 13);
            this.DeleteLinkLabel.TabIndex = 18;
            this.DeleteLinkLabel.TabStop = true;
            this.DeleteLinkLabel.Text = "Delete";
            this.DeleteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteLinkLabel_LinkClicked);
            // 
            // approveLinkLabel
            // 
            this.approveLinkLabel.AutoSize = true;
            this.approveLinkLabel.Location = new System.Drawing.Point(683, 319);
            this.approveLinkLabel.Name = "approveLinkLabel";
            this.approveLinkLabel.Size = new System.Drawing.Size(47, 13);
            this.approveLinkLabel.TabIndex = 19;
            this.approveLinkLabel.TabStop = true;
            this.approveLinkLabel.Text = "Approve";
            this.approveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.approveLinkLabel_LinkClicked);
            // 
            // cancelLinkLabel
            // 
            this.cancelLinkLabel.AutoSize = true;
            this.cancelLinkLabel.Location = new System.Drawing.Point(796, 319);
            this.cancelLinkLabel.Name = "cancelLinkLabel";
            this.cancelLinkLabel.Size = new System.Drawing.Size(40, 13);
            this.cancelLinkLabel.TabIndex = 20;
            this.cancelLinkLabel.TabStop = true;
            this.cancelLinkLabel.Text = "Cancel";
            this.cancelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cancelLinkLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.statusComboBox);
            this.panel1.Controls.Add(this.endDateTimePicker);
            this.panel1.Controls.Add(this.startDateTimePicker);
            this.panel1.Controls.Add(this.securityComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 382);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Search for Securties";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Click to view corresponding data";
            // 
            // viewDividends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(939, 387);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelLinkLabel);
            this.Controls.Add(this.approveLinkLabel);
            this.Controls.Add(this.DeleteLinkLabel);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.closebtn1);
            this.Controls.Add(this.dividendDataGrid);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Name = "viewDividends";
            this.Text = "View Dividend";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dividendDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView dividendDataGrid;
        private System.Windows.Forms.Button closebtn1;
        private System.Windows.Forms.ComboBox securityComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.LinkLabel editLabel;
        private System.Windows.Forms.LinkLabel DeleteLinkLabel;
        private System.Windows.Forms.LinkLabel approveLinkLabel;
        private System.Windows.Forms.LinkLabel cancelLinkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

