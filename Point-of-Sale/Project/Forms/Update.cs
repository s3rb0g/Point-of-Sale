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
    public partial class FRM_update : Form
    {
        public FRM_update()
        {
            InitializeComponent();
        }

        private void TB_itemNo_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ranie Gobres\\Desktop\\CRUD\\Project\\Project\\Database\\Database.mdf\";Integrated Security=True";
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            if (TB_itemNo.Text != "")
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT [Item Name], Price, Quantity FROM Items WHERE id = @Id", sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Id", int.Parse(TB_itemNo.Text));

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    LBL_itemName.Text = sqlReader.GetValue(0).ToString();
                    TB_price.Text = sqlReader.GetValue(1).ToString();
                    TB_stocks.Text = sqlReader.GetValue(2).ToString();
                }
                sqlConnect.Close();
            }
            else
            {
                LBL_itemName.Text = "";
                TB_price.Text = "";
                TB_stocks.Text = "";
            }


        }

        private void BTN_update_Click(object sender, EventArgs e)
        {
            int itemNo = int.Parse(TB_itemNo.Text);
            int price = int.Parse(TB_price.Text);
            int quantity = int.Parse(TB_stocks.Text);

            DatabaseClass databaseClass = new DatabaseClass();

            databaseClass.updateItems(itemNo, price, quantity);

            FRM_admin admin_form = new FRM_admin();
            this.Close();
            admin_form.Show();
            MessageBox.Show("Updating Successful!");



        }
    }
}
