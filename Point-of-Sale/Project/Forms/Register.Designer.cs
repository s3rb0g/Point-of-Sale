namespace Project.Forms
{
    partial class FRM_register
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
            this.TB_fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_month = new System.Windows.Forms.ComboBox();
            this.CB_day = new System.Windows.Forms.ComboBox();
            this.CB_year = new System.Windows.Forms.ComboBox();
            this.BTN_back = new System.Windows.Forms.Button();
            this.BTN_create = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_fullname
            // 
            this.TB_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_fullname.Location = new System.Drawing.Point(260, 128);
            this.TB_fullname.Name = "TB_fullname";
            this.TB_fullname.Size = new System.Drawing.Size(245, 34);
            this.TB_fullname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fullname:";
            // 
            // Tb_username
            // 
            this.Tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_username.Location = new System.Drawing.Point(260, 195);
            this.Tb_username.Name = "Tb_username";
            this.Tb_username.Size = new System.Drawing.Size(245, 34);
            this.Tb_username.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // TB_password
            // 
            this.TB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_password.Location = new System.Drawing.Point(260, 257);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(245, 34);
            this.TB_password.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // CB_gender
            // 
            this.CB_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_gender.FormattingEnabled = true;
            this.CB_gender.Location = new System.Drawing.Point(260, 328);
            this.CB_gender.Name = "CB_gender";
            this.CB_gender.Size = new System.Drawing.Size(121, 37);
            this.CB_gender.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Birthday:";
            // 
            // CB_month
            // 
            this.CB_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_month.FormattingEnabled = true;
            this.CB_month.Location = new System.Drawing.Point(260, 397);
            this.CB_month.Name = "CB_month";
            this.CB_month.Size = new System.Drawing.Size(121, 37);
            this.CB_month.TabIndex = 13;
            this.CB_month.Text = "Month";
            // 
            // CB_day
            // 
            this.CB_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_day.FormattingEnabled = true;
            this.CB_day.Location = new System.Drawing.Point(412, 397);
            this.CB_day.Name = "CB_day";
            this.CB_day.Size = new System.Drawing.Size(121, 37);
            this.CB_day.TabIndex = 15;
            this.CB_day.Text = "Day";
            // 
            // CB_year
            // 
            this.CB_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_year.FormattingEnabled = true;
            this.CB_year.Location = new System.Drawing.Point(567, 397);
            this.CB_year.Name = "CB_year";
            this.CB_year.Size = new System.Drawing.Size(121, 37);
            this.CB_year.TabIndex = 16;
            this.CB_year.Text = "Year";
            // 
            // BTN_back
            // 
            this.BTN_back.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_back.Location = new System.Drawing.Point(508, 496);
            this.BTN_back.Name = "BTN_back";
            this.BTN_back.Size = new System.Drawing.Size(114, 46);
            this.BTN_back.TabIndex = 18;
            this.BTN_back.Text = "Back";
            this.BTN_back.UseVisualStyleBackColor = false;
            this.BTN_back.Click += new System.EventHandler(this.BTN_back_Click);
            // 
            // BTN_create
            // 
            this.BTN_create.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_create.Location = new System.Drawing.Point(648, 496);
            this.BTN_create.Name = "BTN_create";
            this.BTN_create.Size = new System.Drawing.Size(114, 46);
            this.BTN_create.TabIndex = 17;
            this.BTN_create.Text = "Create";
            this.BTN_create.UseVisualStyleBackColor = false;
            this.BTN_create.Click += new System.EventHandler(this.BTN_create_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 42);
            this.label6.TabIndex = 19;
            this.label6.Text = "Create an account:";
            // 
            // FRM_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(811, 586);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTN_back);
            this.Controls.Add(this.BTN_create);
            this.Controls.Add(this.CB_year);
            this.Controls.Add(this.CB_day);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_gender);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_fullname);
            this.Controls.Add(this.label2);
            this.Name = "FRM_register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FRM_register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_month;
        private System.Windows.Forms.ComboBox CB_day;
        private System.Windows.Forms.ComboBox CB_year;
        private System.Windows.Forms.Button BTN_back;
        private System.Windows.Forms.Button BTN_create;
        private System.Windows.Forms.Label label6;
    }
}