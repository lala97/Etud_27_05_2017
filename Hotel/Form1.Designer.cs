namespace Hotel
{
    partial class Form1
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_pasword = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(45, 106);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(83, 15);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username *";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(48, 142);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(268, 20);
            this.txt_username.TabIndex = 1;
            // 
            // lbl_pasword
            // 
            this.lbl_pasword.AutoSize = true;
            this.lbl_pasword.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_pasword.Location = new System.Drawing.Point(48, 218);
            this.lbl_pasword.Name = "lbl_pasword";
            this.lbl_pasword.Size = new System.Drawing.Size(83, 15);
            this.lbl_pasword.TabIndex = 2;
            this.lbl_pasword.Text = "Password *";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(48, 255);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(268, 20);
            this.txt_password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_login.Location = new System.Drawing.Point(129, 325);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(125, 31);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Sign In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 398);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_pasword);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_pasword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
    }
}

