namespace WindowsFormsApplication2
{
    partial class loginscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginscreen));
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1224adasd515qwsdasd = new System.Windows.Forms.PictureBox();
            this.btnLoginExit = new System.Windows.Forms.Button();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1224adasd515qwsdasd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoginUsername.ForeColor = System.Drawing.Color.Black;
            this.txtLoginUsername.Location = new System.Drawing.Point(301, 170);
            this.txtLoginUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginUsername.MaxLength = 10;
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(139, 22);
            this.txtLoginUsername.TabIndex = 81;
            this.txtLoginUsername.TextChanged += new System.EventHandler(this.txtLoginUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "Password:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoginPassword.ForeColor = System.Drawing.Color.Black;
            this.txtLoginPassword.Location = new System.Drawing.Point(301, 213);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginPassword.MaxLength = 666;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '•';
            this.txtLoginPassword.Size = new System.Drawing.Size(139, 22);
            this.txtLoginPassword.TabIndex = 83;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources._53864662_2521071171254534_9121903262688083968_n;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 318);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox1224adasd515qwsdasd
            // 
            this.pictureBox1224adasd515qwsdasd.Image = global::WindowsFormsApplication2.Properties.Resources.Untitled_12;
            this.pictureBox1224adasd515qwsdasd.Location = new System.Drawing.Point(168, 15);
            this.pictureBox1224adasd515qwsdasd.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1224adasd515qwsdasd.Name = "pictureBox1224adasd515qwsdasd";
            this.pictureBox1224adasd515qwsdasd.Size = new System.Drawing.Size(273, 133);
            this.pictureBox1224adasd515qwsdasd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1224adasd515qwsdasd.TabIndex = 79;
            this.pictureBox1224adasd515qwsdasd.TabStop = false;
            // 
            // btnLoginExit
            // 
            this.btnLoginExit.Location = new System.Drawing.Point(333, 270);
            this.btnLoginExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginExit.Name = "btnLoginExit";
            this.btnLoginExit.Size = new System.Drawing.Size(108, 28);
            this.btnLoginExit.TabIndex = 86;
            this.btnLoginExit.Text = "Exit Application";
            this.btnLoginExit.UseVisualStyleBackColor = true;
            this.btnLoginExit.Click += new System.EventHandler(this.btnLoginExit_Click);
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Location = new System.Drawing.Point(168, 270);
            this.btnLoginLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLoginLogin.TabIndex = 85;
            this.btnLoginLogin.Text = "Login";
            this.btnLoginLogin.UseVisualStyleBackColor = true;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // loginscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(609, 367);
            this.Controls.Add(this.btnLoginExit);
            this.Controls.Add(this.btnLoginLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1224adasd515qwsdasd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1224adasd515qwsdasd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1224adasd515qwsdasd;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoginExit;
        private System.Windows.Forms.Button btnLoginLogin;
    }
}