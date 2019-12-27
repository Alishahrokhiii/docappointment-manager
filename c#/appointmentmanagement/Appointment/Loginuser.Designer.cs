namespace Appointment
{
    partial class Loginuser
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
            this.txtUser11 = new System.Windows.Forms.TextBox();
            this.txtPass11 = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser11
            // 
            this.txtUser11.Location = new System.Drawing.Point(108, 128);
            this.txtUser11.Name = "txtUser11";
            this.txtUser11.Size = new System.Drawing.Size(100, 20);
            this.txtUser11.TabIndex = 0;
            // 
            // txtPass11
            // 
            this.txtPass11.Location = new System.Drawing.Point(108, 154);
            this.txtPass11.Name = "txtPass11";
            this.txtPass11.PasswordChar = '*';
            this.txtPass11.Size = new System.Drawing.Size(100, 20);
            this.txtPass11.TabIndex = 1;
            // 
            // TxtUsername
            // 
            this.TxtUsername.AutoSize = true;
            this.TxtUsername.Location = new System.Drawing.Point(48, 128);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(55, 13);
            this.TxtUsername.TabIndex = 2;
            this.TxtUsername.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.Location = new System.Drawing.Point(48, 161);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(59, 13);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.Text = "Password :";
            // 
            // btnlogin
            // 
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlogin.Location = new System.Drawing.Point(121, 194);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Loginuser
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.txtPass11);
            this.Controls.Add(this.txtUser11);
            this.Name = "Loginuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginuser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser11;
        private System.Windows.Forms.TextBox txtPass11;
        private System.Windows.Forms.Label TxtUsername;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label1;
    }
}