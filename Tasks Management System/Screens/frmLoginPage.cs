using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;
using Core;
using static To_Do_List_Project.frmDailyToDoTasks;

namespace To_Do_List_Project.Screens
{
    public  partial class frmLoginPage : Form
    {
        public frmLoginPage() => InitializeComponent();

        private string _FileName = "Users.txt";


        int _Logins = 3;
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
  
            if(clsUser._CheckUserExists(txtUserName.Text,txtPassword.Text,_FileName))
            {

            Form frmMainScreen = new frmMain();
                frmMainScreen.Show();
                this.Close();
            }
            else
            {
                _Logins--;
                if (_Logins > 0)
                    MessageBox.Show($"UserName or Password are not valid !\nyou have {_Logins} attempts left.","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else if (_Logins == 0)
                {
                    MessageBox.Show("Sorry the applicaiton will be closed because you have many tries and you did'nt successfully login, try again and sign up if you don't have an account", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnExit_Click(sender, e);
                }
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form frmLogin=new frmSignUp();
            frmLogin.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Validate_TextBox(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Tag == txtPassword.Tag)
                txtUserName.CausesValidation = false;//this will not trigger validation when click on txtUserName
                     

            clsUtilControls.ValidateTextBox(sender, errorProvider1, e);
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {
            btnExit.CausesValidation = false;//this tells winforms not to trigger the text box validation when clicking on btnExit by user.
            //this wont trigger text box validation or any validation in the form when clicking on btnExit by the user.

        }

        private void frmLoginPage_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
            //if we call txtusername in form_load event :
            //the it runs to early , because the load event excute before form being displayed and shown event happend after the form is visible ,
            //So , the windows is not yet ready to accept focus because :
            //windows reset focus later when showing the form ,so my call is overriden
            //After your Load finishes, Windows runs its own logic and resets focus based on TabIndex, ActiveControl, and other rules.
            //When you move the call to Shown, it works because:
            //Windows already finished setting initial focus.
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            txtUserName.CausesValidation = true;
        }
    }
}
