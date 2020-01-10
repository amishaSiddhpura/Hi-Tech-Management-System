namespace ProjectHiTech.Presentation
{
    partial class AccountantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxtotalPrice = new System.Windows.Forms.TextBox();
            this.textBoxInvoiceID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.comboBoxTOP = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonDisplay);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.comboBoxTOP);
            this.groupBox1.Controls.Add(this.buttonPrint);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxtotalPrice);
            this.groupBox1.Controls.Add(this.textBoxInvoiceID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(171, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.LightCoral;
            this.buttonPrint.Location = new System.Drawing.Point(460, 174);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 35);
            this.buttonPrint.TabIndex = 11;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDelete.Location = new System.Drawing.Point(460, 123);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 35);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightCoral;
            this.buttonUpdate.Location = new System.Drawing.Point(460, 70);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 35);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAdd.Location = new System.Drawing.Point(460, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 35);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxtotalPrice
            // 
            this.textBoxtotalPrice.Location = new System.Drawing.Point(191, 113);
            this.textBoxtotalPrice.Name = "textBoxtotalPrice";
            this.textBoxtotalPrice.Size = new System.Drawing.Size(204, 24);
            this.textBoxtotalPrice.TabIndex = 6;
            // 
            // textBoxInvoiceID
            // 
            this.textBoxInvoiceID.Location = new System.Drawing.Point(191, 33);
            this.textBoxInvoiceID.Name = "textBoxInvoiceID";
            this.textBoxInvoiceID.Size = new System.Drawing.Size(204, 24);
            this.textBoxInvoiceID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type of Payment :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "TotalPrice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Date:";
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(215, 271);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.Size = new System.Drawing.Size(491, 199);
            this.dataGridViewShow.TabIndex = 2;
            this.dataGridViewShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShow_CellContentClick);
            // 
            // comboBoxTOP
            // 
            this.comboBoxTOP.FormattingEnabled = true;
            this.comboBoxTOP.Items.AddRange(new object[] {
            "Phone",
            "Email",
            "Fax Number"});
            this.comboBoxTOP.Location = new System.Drawing.Point(191, 151);
            this.comboBoxTOP.Name = "comboBoxTOP";
            this.comboBoxTOP.Size = new System.Drawing.Size(204, 26);
            this.comboBoxTOP.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(191, 73);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(204, 24);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDisplay.Location = new System.Drawing.Point(258, 203);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 35);
            this.buttonDisplay.TabIndex = 14;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(939, 482);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountantForm";
            this.Text = "Accountant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxtotalPrice;
        private System.Windows.Forms.TextBox textBoxInvoiceID;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.ComboBox comboBoxTOP;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonDisplay;
    }
}