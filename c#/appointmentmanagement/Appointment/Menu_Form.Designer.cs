namespace Appointment
{
    partial class Menu_Form
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
            this.btnreserve = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnreserve
            // 
            this.btnreserve.Location = new System.Drawing.Point(251, 12);
            this.btnreserve.Name = "btnreserve";
            this.btnreserve.Size = new System.Drawing.Size(216, 91);
            this.btnreserve.TabIndex = 0;
            this.btnreserve.Text = "reserveInfo";
            this.btnreserve.UseVisualStyleBackColor = true;
            this.btnreserve.Click += new System.EventHandler(this.btnreserve_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(12, 12);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(219, 91);
            this.btnPatient.TabIndex = 1;
            this.btnPatient.Text = "patient info";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "LogOut !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 140);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.btnreserve);
            this.Name = "Menu_Form";
            this.Text = "Menu_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnreserve;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button button1;
    }
}