using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static To_Do_List_Project.frmDailyToDoTasks;
using static To_Do_List_Project.Screens.frmLoginPage;
using Core;
using Lib;

namespace To_Do_List_Project.Screens
{
    public partial class frmSignUp : Form
    {
        /*We can use instead of :
         public frmSignUp() 
        {
        InitializeComponent()
        }
         to Shorten the code:
         */
        //Only to shorten the code.
        public frmSignUp() => InitializeComponent();

        private string _FileName = "Users.txt";

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            clsUser._AddUser(txtUserName,txtPassword,_FileName);
            MessageBox.Show("Added Successfully", "Successfully Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form frmLogin = new frmLoginPage();
            frmLogin.Show();

            this.Close();
        }

        private void ValidateTextBox(object sender,CancelEventArgs e)
        {
            if (((TextBox)sender).Tag == txtPassword.Tag)
                txtUserName.CausesValidation = false;//txtUser name wont enter validation event function
                    

            clsUtilControls.ValidateTextBox(sender,errorProvider1,e);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form frmLogin = new frmLoginPage();
            frmLogin.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            btnExit.CausesValidation = false;// this tells winforms not to trigger validation when user clicked on btn_Exit
        }

        private void frmSignUp_Shown(object sender, EventArgs e)
        {   
            txtUserName.Focus();
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            txtUserName.CausesValidation = true;//winforms will trigger validation for txtUserName -> txtUserName will enter validation event function when user tries to leave txtUserName for the validation process.
        }
    }
}
