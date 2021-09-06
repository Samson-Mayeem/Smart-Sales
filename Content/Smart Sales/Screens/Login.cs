using Smart_Sales.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Smart_Sales
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; initial Catalog=smartsales; Integrity Security=True", providerName = "System.Data.SqlClient")
        }

        private bool IsValid()
        {
            if (UserName_txt.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Wrong User Name:", "Please Enter the Right User Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Password_text.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Wrong Password:", "Please Enter the Right Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UserName_txt.Clear();
            Password_text.Clear();
            UserName_txt.Focus();
        } 
    }
}
