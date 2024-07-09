namespace Project.Forms
{
    partial class FRM_admin
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
            this.BTN_logout = new System.Windows.Forms.Button();
            this.BTN_accounts = new System.Windows.Forms.Button();
            this.BTN_items = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.BTN_records = new System.Windows.Forms.Button();
            this.BTN_update = new System.Windows.Forms.Button();
            this.DGV_datashow = new System.Windows.Forms.DataGridView();
            this.BTN_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_datashow)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_logout
            // 
            this.BTN_logout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_logout.Location = new System.Drawing.Point(1172, 27);
            this.BTN_logout.Name = "BTN_logout";
            this.BTN_logout.Size = new System.Drawing.Size(114, 46);
            this.BTN_logout.TabIndex = 6;
            this.BTN_logout.Text = "Log out";
            this.BTN_logout.UseVisualStyleBackColor = false;
            this.BTN_logout.Click += new System.EventHandler(this.BTN_logout_Click);
            // 
            // BTN_accounts
            // 
            this.BTN_accounts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_accounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_accounts.Location = new System.Drawing.Point(49, 27);
            this.BTN_accounts.Name = "BTN_accounts";
            this.BTN_accounts.Size = new System.Drawing.Size(114, 46);
            this.BTN_accounts.TabIndex = 7;
            this.BTN_accounts.Text = "Accounts";
            this.BTN_accounts.UseVisualStyleBackColor = false;
            this.BTN_accounts.Click += new System.EventHandler(this.BTN_accounts_Click);
            // 
            // BTN_items
            // 
            this.BTN_items.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_items.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_items.Location = new System.Drawing.Point(215, 27);
            this.BTN_items.Name = "BTN_items";
            this.BTN_items.Size = new System.Drawing.Size(114, 46);
            this.BTN_items.TabIndex = 8;
            this.BTN_items.Text = "Items";
            this.BTN_items.UseVisualStyleBackColor = false;
            this.BTN_items.Click += new System.EventHandler(this.BTN_items_Click);
            // 
            // BTN_delete
            // 
            this.BTN_delete.BackColor = System.Drawing.Color.Crimson;
            this.BTN_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_delete.Location = new System.Drawing.Point(1172, 486);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(114, 46);
            this.BTN_delete.TabIndex = 9;
            this.BTN_delete.Text = "Delete";
            this.BTN_delete.UseVisualStyleBackColor = false;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // BTN_records
            // 
            this.BTN_records.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_records.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_records.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_records.Location = new System.Drawing.Point(384, 27);
            this.BTN_records.Name = "BTN_records";
            this.BTN_records.Size = new System.Drawing.Size(114, 46);
            this.BTN_records.TabIndex = 10;
            this.BTN_records.Text = "Records";
            this.BTN_records.UseVisualStyleBackColor = false;
            this.BTN_records.Click += new System.EventHandler(this.BTN_records_Click);
            // 
            // BTN_update
            // 
            this.BTN_update.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_update.Location = new System.Drawing.Point(1172, 486);
            this.BTN_update.Name = "BTN_update";
            this.BTN_update.Size = new System.Drawing.Size(114, 46);
            this.BTN_update.TabIndex = 11;
            this.BTN_update.Text = "Update";
            this.BTN_update.UseVisualStyleBackColor = false;
            this.BTN_update.Click += new System.EventHandler(this.BTN_update_Click);
            // 
            // DGV_datashow
            // 
            this.DGV_datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_datashow.Location = new System.Drawing.Point(12, 98);
            this.DGV_datashow.Name = "DGV_datashow";
            this.DGV_datashow.RowHeadersWidth = 51;
            this.DGV_datashow.RowTemplate.Height = 24;
            this.DGV_datashow.Size = new System.Drawing.Size(1140, 465);
            this.DGV_datashow.TabIndex = 12;
            // 
            // BTN_refresh
            // 
            this.BTN_refresh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_refresh.Location = new System.Drawing.Point(1172, 419);
            this.BTN_refresh.Name = "BTN_refresh";
            this.BTN_refresh.Size = new System.Drawing.Size(114, 46);
            this.BTN_refresh.TabIndex = 13;
            this.BTN_refresh.Text = "Refresh";
            this.BTN_refresh.UseVisualStyleBackColor = false;
            this.BTN_refresh.Click += new System.EventHandler(this.BTN_refresh_Click);
            // 
            // FRM_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1316, 596);
            this.Controls.Add(this.BTN_refresh);
            this.Controls.Add(this.DGV_datashow);
            this.Controls.Add(this.BTN_update);
            this.Controls.Add(this.BTN_records);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.BTN_items);
            this.Controls.Add(this.BTN_accounts);
            this.Controls.Add(this.BTN_logout);
            this.Name = "FRM_admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FRM_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_datashow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_logout;
        private System.Windows.Forms.Button BTN_accounts;
        private System.Windows.Forms.Button BTN_items;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.Button BTN_records;
        private System.Windows.Forms.Button BTN_update;
        private System.Windows.Forms.DataGridView DGV_datashow;
        private System.Windows.Forms.Button BTN_refresh;
    }
}