namespace ProjectHiTech.Presentation
{
    partial class OrderClerksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderClerksForm));
            this.dataGridViewShowCustomerData = new System.Windows.Forms.DataGridView();
            this.dataGridViewSearchedCustomerData = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.comboBoxSearchCustomer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.buttonAddCustomr = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomrID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerOrderID1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSearchBookData = new System.Windows.Forms.DataGridView();
            this.dataGridViewShowBookData = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDElete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.textBoxCustomerOrderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCustomerData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedCustomerData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchBookData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBookData)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewShowCustomerData
            // 
            this.dataGridViewShowCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCustomerData.Location = new System.Drawing.Point(17, 274);
            this.dataGridViewShowCustomerData.Name = "dataGridViewShowCustomerData";
            this.dataGridViewShowCustomerData.Size = new System.Drawing.Size(525, 185);
            this.dataGridViewShowCustomerData.TabIndex = 2;
            this.dataGridViewShowCustomerData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowCustomerData_CellContentClick);
            // 
            // dataGridViewSearchedCustomerData
            // 
            this.dataGridViewSearchedCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchedCustomerData.Location = new System.Drawing.Point(548, 274);
            this.dataGridViewSearchedCustomerData.Name = "dataGridViewSearchedCustomerData";
            this.dataGridViewSearchedCustomerData.Size = new System.Drawing.Size(465, 185);
            this.dataGridViewSearchedCustomerData.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 491);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridViewShowCustomerData);
            this.tabPage1.Controls.Add(this.dataGridViewSearchedCustomerData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1031, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxSearchCustomer);
            this.groupBox2.Controls.Add(this.comboBoxSearchCustomer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(548, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 224);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Details";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightCoral;
            this.buttonSearch.Location = new System.Drawing.Point(188, 182);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(86, 36);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchCustomer
            // 
            this.textBoxSearchCustomer.Location = new System.Drawing.Point(59, 141);
            this.textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            this.textBoxSearchCustomer.Size = new System.Drawing.Size(314, 25);
            this.textBoxSearchCustomer.TabIndex = 3;
            // 
            // comboBoxSearchCustomer
            // 
            this.comboBoxSearchCustomer.FormattingEnabled = true;
            this.comboBoxSearchCustomer.Items.AddRange(new object[] {
            "CustomerOrderID",
            "CustomerID",
            "CustomerName"});
            this.comboBoxSearchCustomer.Location = new System.Drawing.Point(166, 48);
            this.comboBoxSearchCustomer.Name = "comboBoxSearchCustomer";
            this.comboBoxSearchCustomer.Size = new System.Drawing.Size(207, 26);
            this.comboBoxSearchCustomer.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Please enter information related to your field:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search Field :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteCustomer);
            this.groupBox1.Controls.Add(this.buttonUpdateCustomer);
            this.groupBox1.Controls.Add(this.buttonAddCustomr);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCustomrID);
            this.groupBox1.Controls.Add(this.textBoxCustomerOrderID1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Order Details";
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(336, 175);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(75, 36);
            this.buttonDeleteCustomer.TabIndex = 10;
            this.buttonDeleteCustomer.Text = "Delete";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = false;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.BackColor = System.Drawing.Color.LightCoral;
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(190, 175);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(75, 36);
            this.buttonUpdateCustomer.TabIndex = 9;
            this.buttonUpdateCustomer.Text = "Update";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = false;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
            // 
            // buttonAddCustomr
            // 
            this.buttonAddCustomr.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAddCustomr.Location = new System.Drawing.Point(42, 175);
            this.buttonAddCustomr.Name = "buttonAddCustomr";
            this.buttonAddCustomr.Size = new System.Drawing.Size(75, 36);
            this.buttonAddCustomr.TabIndex = 8;
            this.buttonAddCustomr.Text = "Add";
            this.buttonAddCustomr.UseVisualStyleBackColor = false;
            this.buttonAddCustomr.Click += new System.EventHandler(this.buttonAddCustomr_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 25);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "CustomerOrderId:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Order Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "CustomerID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 3;
            // 
            // textBoxCustomrID
            // 
            this.textBoxCustomrID.Location = new System.Drawing.Point(237, 78);
            this.textBoxCustomrID.Name = "textBoxCustomrID";
            this.textBoxCustomrID.Size = new System.Drawing.Size(174, 25);
            this.textBoxCustomrID.TabIndex = 1;
            // 
            // textBoxCustomerOrderID1
            // 
            this.textBoxCustomerOrderID1.Location = new System.Drawing.Point(237, 36);
            this.textBoxCustomerOrderID1.Name = "textBoxCustomerOrderID1";
            this.textBoxCustomerOrderID1.Size = new System.Drawing.Size(174, 25);
            this.textBoxCustomerOrderID1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewSearchBookData);
            this.tabPage2.Controls.Add(this.dataGridViewShowBookData);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Book OrderDetails";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSearchBookData
            // 
            this.dataGridViewSearchBookData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchBookData.Location = new System.Drawing.Point(576, 234);
            this.dataGridViewSearchBookData.Name = "dataGridViewSearchBookData";
            this.dataGridViewSearchBookData.Size = new System.Drawing.Size(424, 216);
            this.dataGridViewSearchBookData.TabIndex = 6;
            // 
            // dataGridViewShowBookData
            // 
            this.dataGridViewShowBookData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowBookData.Location = new System.Drawing.Point(23, 234);
            this.dataGridViewShowBookData.Name = "dataGridViewShowBookData";
            this.dataGridViewShowBookData.Size = new System.Drawing.Size(538, 216);
            this.dataGridViewShowBookData.TabIndex = 5;
            this.dataGridViewShowBookData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowBookData_CellContentClick_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxSearch);
            this.groupBox4.Controls.Add(this.comboBoxSearch);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(576, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 197);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search book";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(73, 138);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(268, 25);
            this.textBoxSearch.TabIndex = 3;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(189, 40);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(152, 26);
            this.comboBoxSearch.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(309, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Please enter information related to your field:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Search Field ;";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDElete);
            this.groupBox3.Controls.Add(this.buttonUpdate);
            this.groupBox3.Controls.Add(this.buttonADD);
            this.groupBox3.Controls.Add(this.textBoxQuantity);
            this.groupBox3.Controls.Add(this.textBoxBookId);
            this.groupBox3.Controls.Add(this.textBoxCustomerOrderID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 197);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book OrderDetails";
            // 
            // buttonDElete
            // 
            this.buttonDElete.Location = new System.Drawing.Point(368, 123);
            this.buttonDElete.Name = "buttonDElete";
            this.buttonDElete.Size = new System.Drawing.Size(118, 25);
            this.buttonDElete.TabIndex = 8;
            this.buttonDElete.Text = "Delete";
            this.buttonDElete.UseVisualStyleBackColor = true;
            this.buttonDElete.Click += new System.EventHandler(this.buttonDElete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(368, 83);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(118, 29);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(368, 43);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(118, 29);
            this.buttonADD.TabIndex = 6;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(208, 123);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 25);
            this.textBoxQuantity.TabIndex = 5;
            // 
            // textBoxBookId
            // 
            this.textBoxBookId.Location = new System.Drawing.Point(208, 87);
            this.textBoxBookId.Name = "textBoxBookId";
            this.textBoxBookId.Size = new System.Drawing.Size(100, 25);
            this.textBoxBookId.TabIndex = 4;
            // 
            // textBoxCustomerOrderID
            // 
            this.textBoxCustomerOrderID.Location = new System.Drawing.Point(208, 51);
            this.textBoxCustomerOrderID.Name = "textBoxCustomerOrderID";
            this.textBoxCustomerOrderID.Size = new System.Drawing.Size(100, 25);
            this.textBoxCustomerOrderID.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "CustomerOrderID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Book OrderQuantity :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Book ID:";
            // 
            // OrderClerksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1063, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "OrderClerksForm";
            this.Text = "OrderClerks";
            this.Load += new System.EventHandler(this.OrderClerksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCustomerData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedCustomerData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchBookData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBookData)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewShowCustomerData;
        private System.Windows.Forms.DataGridView dataGridViewSearchedCustomerData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustomrID;
        private System.Windows.Forms.TextBox textBoxCustomerOrderID1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Button buttonAddCustomr;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchCustomer;
        private System.Windows.Forms.ComboBox comboBoxSearchCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxBookId;
        private System.Windows.Forms.TextBox textBoxCustomerOrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDElete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewSearchBookData;
        private System.Windows.Forms.DataGridView dataGridViewShowBookData;
    }
}