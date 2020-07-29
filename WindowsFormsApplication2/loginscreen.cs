using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class loginscreen : Form
    {
        public loginscreen()
        {
            InitializeComponent();
        }


        public static string SetValueForText1 = "";



        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginUsername.Text == "SHAKTHI" && txtLoginPassword.Text == "123")
         {
                SetValueForText1 = txtLoginUsername.Text;
                this.Hide();
                frmHomePage frmHomePage = new frmHomePage();
                frmHomePage.Show();
            }
            else if ( txtLoginUsername.Text == "OLITHI" && txtLoginPassword.Text == "321")
            {
                SetValueForText1 = txtLoginUsername.Text;
                this.Hide();
                frmHomePage frmHomePage = new frmHomePage();
                frmHomePage.Show();
            }
            
            else
            
            {
                MessageBox.Show("Wrong Username & Password", "Invalid Username & Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { } 
        }

        private void txtLoginUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginscreen_Load(object sender, EventArgs e)
        {

        }

        public class UserDisplayName
        {
            public static string displayName;
        }


    }
}
