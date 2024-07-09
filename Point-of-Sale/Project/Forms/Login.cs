using Project.Classes;
using Project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FRM_login : Form
    {

        private DatabaseClass databaseClass = new DatabaseClass();
        private FRM_admin admin_form = new FRM_admin();

        public FRM_login()
        {
            InitializeComponent();
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            string username = TB_username.Text;
            string password = TB_password.Text;

            bool verified = databaseClass.Verifiy_Account(username, password);

            if (username == "Admin" && password == "Admin")
            {
                this.Hide();
                admin_form.Show();
                MessageBox.Show("Login Successfuly!");
            }
            else if (verified)
            {
                FRM_user user_form = new FRM_user(databaseClass.getUsername());
                this.Hide();
                user_form.Show();
                MessageBox.Show("Login Successfuly!");
            }
            else 
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

            TB_username.Clear();
            TB_password.Clear();

        }

        private void BTN_register_Click(object sender, EventArgs e)
        {
            FRM_register register_form = new FRM_register();
            this.Hide();
            register_form.Show();
        }
    }
}
