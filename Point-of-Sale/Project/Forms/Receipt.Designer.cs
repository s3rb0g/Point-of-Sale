namespace Project.Forms
{
    partial class FRM_receipt
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
            this.BTN_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_amount = new System.Windows.Forms.TextBox();
            this.BTN_enter = new System.Windows.Forms.Button();
            this.LB_showreceipt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTN_back
            // 
            this.BTN_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_back.Location = new System.Drawing.Point(664, 565);
            this.BTN_back.Name = "BTN_back";
            this.BTN_back.Size = new System.Drawing.Size(114, 46);
            this.BTN_back.TabIndex = 6;
            this.BTN_back.Text = "Back";
            this.BTN_back.UseVisualStyleBackColor = true;
            this.BTN_back.Click += new System.EventHandler(this.BTN_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter the amout:";
            // 
            // TB_amount
            // 
            this.TB_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_amount.Location = new System.Drawing.Point(487, 209);
            this.TB_amount.Name = "TB_amount";
            this.TB_amount.Size = new System.Drawing.Size(291, 45);
            this.TB_amount.TabIndex = 9;
            this.TB_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_enter
            // 
            this.BTN_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_enter.Location = new System.Drawing.Point(664, 272);
            this.BTN_enter.Name = "BTN_enter";
            this.BTN_enter.Size = new System.Drawing.Size(114, 39);
            this.BTN_enter.TabIndex = 10;
            this.BTN_enter.Text = "Enter";
            this.BTN_enter.UseVisualStyleBackColor = true;
            this.BTN_enter.Click += new System.EventHandler(this.BTN_enter_Click);
            // 
            // LB_showreceipt
            // 
            this.LB_showreceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_showreceipt.FormattingEnabled = true;
            this.LB_showreceipt.ItemHeight = 25;
            this.LB_showreceipt.Location = new System.Drawing.Point(12, 12);
            this.LB_showreceipt.Name = "LB_showreceipt";
            this.LB_showreceipt.Size = new System.Drawing.Size(463, 604);
            this.LB_showreceipt.TabIndex = 11;
            // 
            // FRM_receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.LB_showreceipt);
            this.Controls.Add(this.BTN_enter);
            this.Controls.Add(this.TB_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_back);
            this.Name = "FRM_receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.FRM_receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_amount;
        private System.Windows.Forms.Button BTN_enter;
        private System.Windows.Forms.ListBox LB_showreceipt;
    }
}