namespace election
{
    partial class Auth
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
            this.txtBoxAuthLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAuthPassword = new System.Windows.Forms.TextBox();
            this.btnAuthLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // txtBoxAuthLogin
            // 
            this.txtBoxAuthLogin.Location = new System.Drawing.Point(12, 25);
            this.txtBoxAuthLogin.Name = "txtBoxAuthLogin";
            this.txtBoxAuthLogin.Size = new System.Drawing.Size(185, 20);
            this.txtBoxAuthLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // txtBoxAuthPassword
            // 
            this.txtBoxAuthPassword.Location = new System.Drawing.Point(12, 64);
            this.txtBoxAuthPassword.Name = "txtBoxAuthPassword";
            this.txtBoxAuthPassword.Size = new System.Drawing.Size(185, 20);
            this.txtBoxAuthPassword.TabIndex = 1;
            // 
            // btnAuthLogIn
            // 
            this.btnAuthLogIn.Location = new System.Drawing.Point(12, 90);
            this.btnAuthLogIn.Name = "btnAuthLogIn";
            this.btnAuthLogIn.Size = new System.Drawing.Size(185, 23);
            this.btnAuthLogIn.TabIndex = 3;
            this.btnAuthLogIn.Text = "Авторизироваться";
            this.btnAuthLogIn.UseVisualStyleBackColor = true;
            this.btnAuthLogIn.Click += new System.EventHandler(this.btnAuthLogIn_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 122);
            this.Controls.Add(this.btnAuthLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxAuthPassword);
            this.Controls.Add(this.txtBoxAuthLogin);
            this.Controls.Add(this.label1);
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAuthLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAuthPassword;
        private System.Windows.Forms.Button btnAuthLogIn;
    }
}