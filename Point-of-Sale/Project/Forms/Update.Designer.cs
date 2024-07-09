namespace Project.Forms
{
    partial class FRM_update
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
            this.BTN_update = new System.Windows.Forms.Button();
            this.TB_itemNo = new System.Windows.Forms.TextBox();
            this.TB_price = new System.Windows.Forms.TextBox();
            this.TB_stocks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_itemName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_update
            // 
            this.BTN_update.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_update.Location = new System.Drawing.Point(183, 457);
            this.BTN_update.Name = "BTN_update";
            this.BTN_update.Size = new System.Drawing.Size(114, 46);
            this.BTN_update.TabIndex = 12;
            this.BTN_update.Text = "Update";
            this.BTN_update.UseVisualStyleBackColor = false;
            this.BTN_update.Click += new System.EventHandler(this.BTN_update_Click);
            // 
            // TB_itemNo
            // 
            this.TB_itemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_itemNo.Location = new System.Drawing.Point(229, 164);
            this.TB_itemNo.Name = "TB_itemNo";
            this.TB_itemNo.Size = new System.Drawing.Size(241, 45);
            this.TB_itemNo.TabIndex = 13;
            this.TB_itemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_itemNo.TextChanged += new System.EventHandler(this.TB_itemNo_TextChanged);
            // 
            // TB_price
            // 
            this.TB_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_price.Location = new System.Drawing.Point(229, 251);
            this.TB_price.Name = "TB_price";
            this.TB_price.Size = new System.Drawing.Size(241, 45);
            this.TB_price.TabIndex = 14;
            this.TB_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_stocks
            // 
            this.TB_stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_stocks.Location = new System.Drawing.Point(229, 336);
            this.TB_stocks.Name = "TB_stocks";
            this.TB_stocks.Size = new System.Drawing.Size(241, 45);
            this.TB_stocks.TabIndex = 15;
            this.TB_stocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Item No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Stocks:";
            // 
            // LBL_itemName
            // 
            this.LBL_itemName.AutoSize = true;
            this.LBL_itemName.BackColor = System.Drawing.Color.BurlyWood;
            this.LBL_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_itemName.Location = new System.Drawing.Point(36, 48);
            this.LBL_itemName.Name = "LBL_itemName";
            this.LBL_itemName.Size = new System.Drawing.Size(0, 54);
            this.LBL_itemName.TabIndex = 19;
            // 
            // FRM_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(514, 558);
            this.Controls.Add(this.LBL_itemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_stocks);
            this.Controls.Add(this.TB_price);
            this.Controls.Add(this.TB_itemNo);
            this.Controls.Add(this.BTN_update);
            this.Name = "FRM_update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_update;
        private System.Windows.Forms.TextBox TB_itemNo;
        private System.Windows.Forms.TextBox TB_price;
        private System.Windows.Forms.TextBox TB_stocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_itemName;
    }
}