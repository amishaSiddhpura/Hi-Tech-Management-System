namespace ProjectHiTech.Presentation
{
    partial class SalesManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesManagerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.textBoxFaxNo = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.textBoxStreetName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustomerID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxCreditLimit);
            this.groupBox1.Controls.Add(this.textBoxFaxNo);
            this.groupBox1.Controls.Add(this.textBoxPhoneNo);
            this.groupBox1.Controls.Add(this.textBoxPostalCode);
            this.groupBox1.Controls.Add(this.textBoxCityName);
            this.groupBox1.Controls.Add(this.textBoxStreetName);
            this.groupBox1.Controls.Add(this.textBoxCustomerName);
            this.groupBox1.Controls.Add(this.textBoxCustomerId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDelete.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(340, 180);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 36);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightCoral;
            this.buttonUpdate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(175, 180);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(108, 36);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAdd.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(31, 180);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 36);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxCreditLimit
            // 
            this.textBoxCreditLimit.Location = new System.Drawing.Point(362, 131);
            this.textBoxCreditLimit.Name = "textBoxCreditLimit";
            this.textBoxCreditLimit.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreditLimit.TabIndex = 15;
            // 
            // textBoxFaxNo
            // 
            this.textBoxFaxNo.Location = new System.Drawing.Point(362, 101);
            this.textBoxFaxNo.Name = "textBoxFaxNo";
            this.textBoxFaxNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxFaxNo.TabIndex = 14;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(362, 68);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhoneNo.TabIndex = 13;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(362, 31);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 22);
            this.textBoxPostalCode.TabIndex = 12;
            // 
            // textBoxCityName
            // 
            this.textBoxCityName.Location = new System.Drawing.Point(145, 134);
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(100, 22);
            this.textBoxCityName.TabIndex = 11;
            // 
            // textBoxStreetName
            // 
            this.textBoxStreetName.Location = new System.Drawing.Point(145, 101);
            this.textBoxStreetName.Name = "textBoxStreetName";
            this.textBoxStreetName.Size = new System.Drawing.Size(100, 22);
            this.textBoxStreetName.TabIndex = 10;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(145, 67);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustomerName.TabIndex = 9;
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(145, 32);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustomerId.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Credit Limit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fax Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Postal Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "City Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Street Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxSearch);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(534, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 244);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Customer";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightCoral;
            this.buttonSearch.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(149, 191);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(106, 36);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(40, 144);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(253, 22);
            this.textBoxSearch.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Please enter information related to field:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Search By :";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "CustomerID",
            "Customer Name",
            "City"});
            this.comboBoxSearch.Location = new System.Drawing.Point(129, 65);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(167, 24);
            this.comboBoxSearch.TabIndex = 3;
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(12, 263);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.Size = new System.Drawing.Size(509, 212);
            this.dataGridViewShow.TabIndex = 4;
            this.dataGridViewShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShow_CellClick);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(534, 263);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(414, 212);
            this.dataGridViewSearch.TabIndex = 5;
            // 
            // SalesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(960, 487);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesManagerForm";
            this.Text = "SalesManager";
            this.Load += new System.EventHandler(this.SalesManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCreditLimit;
        private System.Windows.Forms.TextBox textBoxFaxNo;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxCityName;
        private System.Windows.Forms.TextBox textBoxStreetName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}