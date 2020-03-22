using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Mangment_System
{
    
    public partial class Login_Form : Form
    {   // the variable will be deleted if not used in the same form
        public string username = "";
        public Login_Form()
        {
            InitializeComponent();
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Saving the user name to use it later when welcoming 
            username= txtUsername.Text;
                
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit App when clicking
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            //Hint Enter 
            if (txtUsername.Text.Equals(@"Username"))
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            //Hint Leave 
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.ForeColor = SystemColors.GrayText;
                txtUsername.Text = @"Username";
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            // Hide the password by default when Entering
                //txtPassword.UseSystemPasswordChar = true;

            //Hint Enter 
            if (txtPassword.Text.Equals(@"Password"))
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = SystemColors.WindowText;
            }
            checkAction();

        }

        private void password_Leave(object sender, EventArgs e)
        {

            // Hint Leave
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.ForeColor = SystemColors.GrayText;
                txtPassword.Text = @"Password";
                
            }

            checkAction();

        }
        private bool login_Check()
        {
            // Feel free to add conditions 
            if (txtUsername.Text==""||txtPassword.Text=="")
            {
            return false;
            }
            else
            {
            return true;
            }
            
        }
        private void show_hideCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            checkAction();
        }
        private void checkAction()
        {
            // if check button is on then show the password in the Passwordtextbox
            //else passwordchar is on
            if (show_hideCheckBox.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void labelAcount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Signup form will popup Here when clicking 
            Form Signup = new Signup_Form();
            Signup.Show();
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            // Main form will popup Here when clicking 
            /* Here you will put your conditions later after connecting to the DB 
            and mapping the username and password to the SQL DB*/

            //this.Hide();
            if (login_Check())
            {
                txterrorMessage.Visible = false;
                Form Main = new Main_Form(username);
                //Application.Run(new Main_Form(username));
                Main.Show();
            }
            else
            {
                txterrorMessage.Visible=true;
            }

        }

    }
}
