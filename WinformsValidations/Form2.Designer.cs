
namespace WinformsValidations
{
    partial class Form2
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
            this.txtLPhone = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLPhone
            // 
            this.txtLPhone.Location = new System.Drawing.Point(324, 141);
            this.txtLPhone.Name = "txtLPhone";
            this.txtLPhone.Size = new System.Drawing.Size(193, 23);
            this.txtLPhone.TabIndex = 7;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(230, 141);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(88, 15);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(324, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(230, 93);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(36, 15);
            this.lblFName.TabIndex = 4;
            this.lblFName.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(354, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Form 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLPhone);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblFName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLPhone;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}