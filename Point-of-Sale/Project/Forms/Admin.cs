using Microsoft.SqlServer.Server;
using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class FRM_admin : Form
    {
        private DatabaseClass databaseclass = new DatabaseClass();
        public FRM_admin()
        {
            InitializeComponent();
        }

        private void BTN_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                databaseclass.removeElements();

                FRM_login login = new FRM_login();
                this.Close();
                login.Show();
                MessageBox.Show("Logout Successfully!");
            }
        }

        private void BTN_accounts_Click(object sender, EventArgs e)
        {
            BTN_Account();

        }
        
        public void BTN_Account()
        {
            clearDGV();
            retrieve();

            BTN_update.Visible = false;

            DGV_datashow.Columns.Add("Id", "ID");
            DGV_datashow.Columns.Add("Fullname", "FULLNAME");
            DGV_datashow.Columns.Add("Username", "USERNAME");
            DGV_datashow.Columns.Add("Password", "PASSWORD");
            DGV_datashow.Columns.Add("Gender", "GENDER");
            DGV_datashow.Columns.Add("Birthday", "BIRTHDAY");

            DGV_datashow.Columns["Id"].Width = 100;
            DGV_datashow.Columns["Fullname"].Width = 140;
            DGV_datashow.Columns["Username"].Width = 140;
            DGV_datashow.Columns["Password"].Width = 140;
            DGV_datashow.Columns["Gender"].Width = 140;
            DGV_datashow.Columns["Birthday"].Width = 140;

            int loop = databaseclass.rangeAccounts();

            for (int i = 0; i < loop; i++)
            {
                DGV_datashow.Rows.Add(databaseclass.getAccountId(i), databaseclass.getAccountName(i), databaseclass.getAccountUssername(i),
                    databaseclass.getAccountPassword(i), databaseclass.getAccountGender(i), databaseclass.getAccountBirthday(i));
            }
        }

        private void BTN_items_Click(object sender, EventArgs e)
        {
            clearDGV();
            retrieve();

            BTN_delete.Visible = false;
            BTN_refresh.Visible = false;

            DGV_datashow.Columns.Add("Id", "ID");
            DGV_datashow.Columns.Add("ItemName", "ITEM NAME");
            DGV_datashow.Columns.Add("Price", "PRICE");
            DGV_datashow.Columns.Add("Quantity", "QUANTITY");

            DGV_datashow.Columns["Id"].Width = 200;
            DGV_datashow.Columns["ItemName"].Width = 200;
            DGV_datashow.Columns["Price"].Width = 200;
            DGV_datashow.Columns["Quantity"].Width = 200;

            int loop = databaseclass.rangeItems();

            for (int i = 0; i < loop; i++)
            {
                DGV_datashow.Rows.Add(databaseclass.getId(i), databaseclass.getName(i), databaseclass.getPrice(i),
                    databaseclass.getQuantity(i));
            }
        }

        private void BTN_records_Click(object sender, EventArgs e)
        {
            clearDGV();
            retrieve();

            BTN_update.Visible = false;
            BTN_delete.Visible = false;
            BTN_refresh.Visible = false;

            DGV_datashow.Columns.Add("Id", "ID");
            DGV_datashow.Columns.Add("CustomerName", "CUSTOMER NAME");
            DGV_datashow.Columns.Add("ItemName", "ITEM NAME");
            DGV_datashow.Columns.Add("Purchased", "NO. PURCHASED");
            DGV_datashow.Columns.Add("Total", "SALES");

            DGV_datashow.Columns["Id"].Width = 120;
            DGV_datashow.Columns["CustomerName"].Width = 170;
            DGV_datashow.Columns["ItemName"].Width = 170;
            DGV_datashow.Columns["Purchased"].Width = 170;
            DGV_datashow.Columns["Total"].Width = 170;

            int loop = databaseclass.rangeRecords();

            for (int i = 0; i < loop; i++)
            {
                DGV_datashow.Rows.Add(databaseclass.getRecordId(i), databaseclass.getRecordCustomerName(i), 
                    databaseclass.getRecordItemName(i), databaseclass.getRecordPurchased(i), databaseclass.getRecordTotal(i));
            }
        }

        public void retrieve()
        {

            databaseclass.removeElements();

            databaseclass.setAccountId();
            databaseclass.setAccountName();
            databaseclass.setAccountUsername();
            databaseclass.setAccountPassword();
            databaseclass.setAccountGender();
            databaseclass.setAccountBirthday();

            databaseclass.setId();
            databaseclass.setName();
            databaseclass.setPrice();
            databaseclass.setPrice();
            databaseclass.setQuantity();

            databaseclass.setRecordId();
            databaseclass.setRecordCustomerName();
            databaseclass.setRecordItemName();
            databaseclass.setRecordPurchase();
            databaseclass.setRecordTotal();


        }

        public void clearDGV()
        {
            BTN_update.Visible = true;
            BTN_delete.Visible = true;
            BTN_refresh.Visible = true;

            DGV_datashow.Rows.Clear();
            DGV_datashow.Columns.Clear();
        }

        private void BTN_update_Click(object sender, EventArgs e)
        {
            FRM_update update_form = new FRM_update();
            this.Hide();
            update_form.Show();
        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            FRM_delete delete_form = new FRM_delete();
            delete_form.Show();

        }

        private void FRM_admin_Load(object sender, EventArgs e)
        {
            BTN_update.Visible = false;
            BTN_delete.Visible = false;
            BTN_refresh.Visible = false;
        }

        private void BTN_refresh_Click(object sender, EventArgs e)
        {
            BTN_Account();

        }
    }
}
