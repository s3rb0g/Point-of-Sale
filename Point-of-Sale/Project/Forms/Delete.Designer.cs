namespace Project.Forms
{
    partial class FRM_delete
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
            this.label3 = new System.Windows.Forms.Label();
            this.TB_accountId = new System.Windows.Forms.TextBox();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the account you want to delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID No.";
            // 
            // TB_accountId
            // 
            this.TB_accountId.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_accountId.Location = new System.Drawing.Point(222, 109);
            this.TB_accountId.Name = "TB_accountId";
            this.TB_accountId.Size = new System.Drawing.Size(241, 45);
            this.TB_accountId.TabIndex = 20;
            this.TB_accountId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_delete
            // 
            this.BTN_delete.BackColor = System.Drawing.Color.Crimson;
            this.BTN_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_delete.Location = new System.Drawing.Point(203, 195);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(114, 46);
            this.BTN_delete.TabIndex = 19;
            this.BTN_delete.Text = "Delete";
            this.BTN_delete.UseVisualStyleBackColor = false;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // FRM_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(565, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_accountId);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.label1);
            this.Name = "FRM_delete";
            this.Text = "Delete an Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_accountId;
        private System.Windows.Forms.Button BTN_delete;
    }
}