namespace Project
{
    partial class FRM_login
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
            this.TB_username = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.BTN_login = new System.Windows.Forms.Button();
            this.BTN_register = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // TB_username
            // 
            this.TB_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_username.Location = new System.Drawing.Point(331, 272);
            this.TB_username.Name = "TB_username";
            this.TB_username.Size = new System.Drawing.Size(245, 34);
            this.TB_username.TabIndex = 2;
            // 
            // TB_password
            // 
            this.TB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_password.Location = new System.Drawing.Point(331, 328);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(245, 34);
            this.TB_password.TabIndex = 3;
            this.TB_password.UseSystemPasswordChar = true;
            // 
            // BTN_login
            // 
            this.BTN_login.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_login.Location = new System.Drawing.Point(394, 434);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(114, 46);
            this.BTN_login.TabIndex = 4;
            this.BTN_login.Text = "Login";
            this.BTN_login.UseVisualStyleBackColor = false;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click);
            // 
            // BTN_register
            // 
            this.BTN_register.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_register.Location = new System.Drawing.Point(221, 434);
            this.BTN_register.Name = "BTN_register";
            this.BTN_register.Size = new System.Drawing.Size(114, 46);
            this.BTN_register.TabIndex = 5;
            this.BTN_register.Text = "Register";
            this.BTN_register.UseVisualStyleBackColor = false;
            this.BTN_register.Click += new System.EventHandler(this.BTN_register_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Ranie Gobres\\Desktop\\CRUD\\Project\\Project\\Pictures\\Logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(208, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(700, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_register);
            this.Controls.Add(this.BTN_login);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_username;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.Button BTN_login;
        private System.Windows.Forms.Button BTN_register;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

