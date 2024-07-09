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
    public partial class FRM_user : Form
    {
        private DatabaseClass databaseclass = new DatabaseClass();
        private MainClass mainclass = new MainClass();

        private string user_Fullname;
        public FRM_user(string name)
        {
            InitializeComponent();
            user_Fullname = name;
        }

        private void FRM_user_Load(object sender, EventArgs e)
        {
            databaseclass.delete_records(); 
            

            Greetings.Text = "Welcome, " + user_Fullname;

            preRun();

            NUD_item1.Minimum = 0;
            NUD_item1.Maximum = databaseclass.getQuantity(0);
            LBL_priceItem1.Text = "₱" + databaseclass.getPrice(0).ToString();
            LBL_quantityItem1.Text = "Qty. " + databaseclass.getQuantity(0).ToString();

            NUD_item2.Minimum = 0;
            NUD_item2.Maximum = databaseclass.getQuantity(1);
            LBL_priceItem2.Text = "₱" + databaseclass.getPrice(1).ToString();
            LBL_quantityItem2.Text = "Qty. " + databaseclass.getQuantity(1).ToString();

            NUD_item3.Minimum = 0;
            NUD_item3.Maximum = databaseclass.getQuantity(2);
            LBL_priceItem3.Text = "₱" + databaseclass.getPrice(2).ToString();
            LBL_quantityItem3.Text = "Qty. " + databaseclass.getQuantity(2).ToString();

            NUD_item4.Minimum = 0;
            NUD_item4.Maximum = databaseclass.getQuantity(3);
            LBL_priceItem4.Text = "₱" + databaseclass.getPrice(3).ToString();
            LBL_quantityItem4.Text = "Qty. " + databaseclass.getQuantity(3).ToString();

            NUD_item5.Minimum = 0;
            NUD_item5.Maximum = databaseclass.getQuantity(4);
            LBL_priceItem5.Text = "₱" + databaseclass.getPrice(4).ToString();
            LBL_quantityItem5.Text = "Qty. " + databaseclass.getQuantity(4).ToString();

            NUD_item6.Minimum = 0;
            NUD_item6.Maximum = databaseclass.getQuantity(5);
            LBL_priceItem6.Text = "₱" + databaseclass.getPrice(5).ToString();
            LBL_quantityItem6.Text = "Qty. " + databaseclass.getQuantity(5).ToString();

            NUD_item7.Minimum = 0;
            NUD_item7.Maximum = databaseclass.getQuantity(6);
            LBL_priceItem7.Text = "₱" + databaseclass.getPrice(6).ToString();
            LBL_quantityItem7.Text = "Qty. " + databaseclass.getQuantity(6).ToString();

            NUD_item8.Minimum = 0;
            NUD_item8.Maximum = databaseclass.getQuantity(7);
            LBL_priceItem8.Text = "₱" + databaseclass.getPrice(7).ToString();
            LBL_quantityItem8.Text = "Qty. " + databaseclass.getQuantity(7).ToString();
        }

        private void BTN_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FRM_login login = new FRM_login();
                this.Close();
                login.Show();
                MessageBox.Show("Logout Successfully!");
            }
        }

        private void BTN_checkout_Click(object sender, EventArgs e)
        {
            decimal item1 = NUD_item1.Value;
            decimal item2 = NUD_item2.Value;
            decimal item3 = NUD_item3.Value;
            decimal item4 = NUD_item4.Value;
            decimal item5 = NUD_item5.Value;
            decimal item6 = NUD_item6.Value;
            decimal item7 = NUD_item7.Value;
            decimal item8 = NUD_item8.Value;

            decimal totalPerItem1 = mainclass.Ordered_Price(item1, databaseclass.getPrice(0));
            decimal totalPerItem2 = mainclass.Ordered_Price(item2, databaseclass.getPrice(1));
            decimal totalPerItem3 = mainclass.Ordered_Price(item3, databaseclass.getPrice(2));
            decimal totalPerItem4 = mainclass.Ordered_Price(item4, databaseclass.getPrice(3));
            decimal totalPerItem5 = mainclass.Ordered_Price(item5, databaseclass.getPrice(4));
            decimal totalPerItem6 = mainclass.Ordered_Price(item6, databaseclass.getPrice(5));
            decimal totalPerItem7 = mainclass.Ordered_Price(item7, databaseclass.getPrice(6));
            decimal totalPerItem8 = mainclass.Ordered_Price(item8, databaseclass.getPrice(7));

            decimal overAllTotal = mainclass.Total_Price(totalPerItem1, totalPerItem2, totalPerItem3,
                totalPerItem4, totalPerItem5, totalPerItem6, totalPerItem7, totalPerItem8);

            string itemName1 = databaseclass.getName(0);
            string itemName2 = databaseclass.getName(1);
            string itemName3 = databaseclass.getName(2);
            string itemName4 = databaseclass.getName(3);
            string itemName5 = databaseclass.getName(4);
            string itemName6 = databaseclass.getName(5);
            string itemName7 = databaseclass.getName(6);
            string itemName8 = databaseclass.getName(7);

            int itemId1 = databaseclass.getId(0);
            int itemId2 = databaseclass.getId(1);
            int itemId3 = databaseclass.getId(2);
            int itemId4 = databaseclass.getId(3);
            int itemId5 = databaseclass.getId(4);
            int itemId6 = databaseclass.getId(5);
            int itemId7 = databaseclass.getId(6);
            int itemId8 = databaseclass.getId(7);

            mainclass.Store_items(item1, item2, item3, item4, item5, item6, item7, item8);

            mainclass.Store_PriceItems(totalPerItem1, totalPerItem2, totalPerItem3, totalPerItem4, totalPerItem5, totalPerItem6, totalPerItem7, totalPerItem8);

            mainclass.Store_Names(itemName1, itemName2, itemName3, itemName4, itemName5, itemName6, itemName7, itemName8);

            mainclass.Store_Id(itemId1, itemId2, itemId3, itemId4, itemId5, itemId6, itemId7, itemId8);

            string officialReceipt = mainclass.Receipt_Message(user_Fullname, overAllTotal);

            FRM_receipt recpt = new FRM_receipt(officialReceipt, user_Fullname, overAllTotal);
            this.Hide();
            recpt.Show();
        }

        public void preRun()
        {
            databaseclass.setQuantity();
            databaseclass.setPrice();
            databaseclass.setName();
            databaseclass.setId();
        }




    }
}
