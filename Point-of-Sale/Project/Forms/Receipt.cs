using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class FRM_receipt : Form
    {
        private string receipt, name;
        private decimal total;
        
        public FRM_receipt(string receipt, string name, decimal total)
        {
            InitializeComponent();

            this.receipt = receipt;
            this.name = name;
            this.total = total;
        }

        private void BTN_back_Click(object sender, EventArgs e)
        {
            FRM_user user_form = new FRM_user(name);
            this.Close();
            user_form.Show();

        }

        private void BTN_enter_Click(object sender, EventArgs e)
        {
            MainClass mainclass = new MainClass();

            decimal pay = Convert.ToDecimal(TB_amount.Text);

            bool correctValue = pay >= total ? true : false;

            if (correctValue)
            {
                decimal change = mainclass.Calculate_Payment(total, pay);

                LB_showreceipt.Items.Add("CASH:\t\t\t\t" + pay);
                LB_showreceipt.Items.Add("");
                LB_showreceipt.Items.Add("CHANGE:\t\t\t" + change);
                LB_showreceipt.Items.Add("*******************************************************");
                LB_showreceipt.Items.Add("");
                LB_showreceipt.Items.Add("\t             THANK YOU!");
                BTN_back.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid payment.");
            }

            TB_amount.Clear();

        }

        private void FRM_receipt_Load(object sender, EventArgs e)
        {
            StringBuilder stringbuilder = new StringBuilder(receipt);

            string[] lines = stringbuilder.ToString().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            int numLines = lines.Length;

            for (int i = 0; i < numLines; i++)
            {
                string line = lines[i];
                LB_showreceipt.Items.Add(line);
            }

            BTN_back.Visible = false;
        }

    }
}
