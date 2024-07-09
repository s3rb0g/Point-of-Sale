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
    public partial class FRM_register : Form
    {
        private MainClass mainclass = new MainClass();
        private DatabaseClass databaseclass = new DatabaseClass();
        public FRM_register()
        {
            InitializeComponent();
        }

        private void FRM_register_Load(object sender, EventArgs e)
        {
            string[] gender = new string[] {"Male", "Female"};
            for (int i = 0; i < gender.Length; i++)
            {
                CB_gender.Items.Add(gender[i]);
            }

            for (int j = 1; j <= 12; j++)
            {
                CB_month.Items.Add(j.ToString());
            }

            for (int k = 1; k <= 31; k++)
            {
                CB_day.Items.Add(k.ToString());
            }

            for (int l = 2024; l >= 1900; l--)
            {
                CB_year.Items.Add(l.ToString());
            }

        }

        private void BTN_create_Click(object sender, EventArgs e)
        {
            string fullname = TB_fullname.Text;
            string username = Tb_username.Text;
            string password = TB_password.Text;
            string gender = CB_gender.SelectedItem.ToString();
            string month = CB_month.SelectedItem.ToString();
            string day = CB_day.SelectedItem.ToString();
            string year = CB_year.SelectedItem.ToString();
            string birthday = month + "/" + day + "/" + year;

            bool returned = mainclass.Check_if_Null(fullname, username, password, gender, month, day, year);

            if (returned)
            {
                MessageBox.Show("Please complete filling up all.");
            }
            else if (username == "Admin" && password == "Admin")
            {
                MessageBox.Show("Invalid Username or Password. \nPlease Try Again");
            }
            else 
            {
                int id = mainclass.Create_Id();
                databaseclass.Store_Account(id, fullname, username, password, gender, birthday);
                MessageBox.Show("Creating an account successfuly!");
            }

            TB_fullname.Clear();
            Tb_username.Clear();
            TB_password.Clear();
            CB_gender.SelectedIndex = -1;
            CB_month.SelectedIndex = -1;
            CB_day.SelectedIndex = -1;
            CB_year.SelectedIndex = -1;

        }

        private void BTN_back_Click(object sender, EventArgs e)
        {
            FRM_login login_form = new FRM_login();
            this.Close();
            login_form.Show();
        }
    }
}
