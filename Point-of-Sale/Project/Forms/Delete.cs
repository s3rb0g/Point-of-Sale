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
    public partial class FRM_delete : Form
    {
        public FRM_delete()
        {
            InitializeComponent();
        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            int accountId = int.Parse(TB_accountId.Text);
            DialogResult result = MessageBox.Show("Are you sure you want to DELETE this account?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                DatabaseClass databaseClass = new DatabaseClass();
                databaseClass.deleteAccount(accountId);
                
                FRM_admin admin_form = new FRM_admin();

                this.Close();
            }
            


        }
    }
}
