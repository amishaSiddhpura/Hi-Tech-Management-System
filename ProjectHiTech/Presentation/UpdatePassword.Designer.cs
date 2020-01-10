namespace ProjectHiTech.Presentation
{
    partial class UpdatePassword
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxnewPass = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPAss = new System.Windows.Forms.TextBox();
            this.buttonUpdatePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(214, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(214, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(214, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(362, 156);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxnewPass
            // 
            this.textBoxnewPass.Location = new System.Drawing.Point(362, 194);
            this.textBoxnewPass.Name = "textBoxnewPass";
            this.textBoxnewPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxnewPass.TabIndex = 4;
            // 
            // textBoxConfirmPAss
            // 
            this.textBoxConfirmPAss.Location = new System.Drawing.Point(362, 239);
            this.textBoxConfirmPAss.Name = "textBoxConfirmPAss";
            this.textBoxConfirmPAss.Size = new System.Drawing.Size(100, 20);
            this.textBoxConfirmPAss.TabIndex = 5;
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonUpdatePassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePassword.Location = new System.Drawing.Point(217, 302);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(245, 36);
            this.buttonUpdatePassword.TabIndex = 6;
            this.buttonUpdatePassword.Text = "Update Password";
            this.buttonUpdatePassword.UseVisualStyleBackColor = false;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.buttonUpdatePassword_Click);
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.buttonUpdatePassword);
            this.Controls.Add(this.textBoxConfirmPAss);
            this.Controls.Add(this.textBoxnewPass);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePassword";
            this.Text = "UpdatePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxnewPass;
        private System.Windows.Forms.TextBox textBoxConfirmPAss;
        private System.Windows.Forms.Button buttonUpdatePassword;
    }
}