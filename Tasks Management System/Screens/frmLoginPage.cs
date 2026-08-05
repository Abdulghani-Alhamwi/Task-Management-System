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
using System.Runtime.InteropServices;

namespace To_Do_List_Project.Screens
{
    public  partial class frmLoginPage : Form
    {
        Form frmProgramLife;
        public frmLoginPage(Form frmHiddenMainForm)
        {
            InitializeComponent();
            frmProgramLife = frmHiddenMainForm;
        }

        private string _FileName = "Users.txt";


        int _Logins = 3;
        bool CloseProgram = true;
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser.stUserInfo CurrentUser = new clsUser.stUserInfo();
            if(clsUser._CheckUserExists(txtUserName.Text,txtPassword.Text,_FileName,ref CurrentUser))
            {
            Form frmMainScreen = new frmMain(frmProgramLife,CurrentUser);
                frmMainScreen.Show();
                CloseProgram = false;
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
            Form SignUp=new frmSignUp(this , frmProgramLife);
            SignUp.Show();
            this.ShowInTaskbar = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       //private const int WindowMessage_SYSCOMMAND = 0x0112;
       //private const int SystemCommand_CLOSE = 0xF060;
        Message _CurrentMessage;
        protected override void WndProc(ref Message m)
        {
            _CurrentMessage = m;
            /*
             * Window is a form or a certain control from the Operating system perspective .
             * wnp is the window procedure and it is a method to recieve and process the messages the are sent from windows to a specific window .
             */
            // if we click close button from the contol box not from a button implement this.Close() -> the following if condition be true :
            //if (m.Msg == WindowMessage_SYSCOMMAND &&
            //    (m.WParam.ToInt32() & 0xFFF0) == SystemCommand_CLOSE)
            //{
            //    MessageBox.Show("Close");
            //    this.Close();
            //    return;
            //}

            base.WndProc(ref m);
        }
        private void Validate_TextBox(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Tag == txtPassword.Tag)
                txtUserName.CausesValidation = false;//this will not trigger validation when click on txtUserName

            if(!(_CurrentMessage.Msg == 16)) // 16 is the window close message , when a window request to be closed -> it sends the message 16 in decimal .
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

        private void frmLoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseProgram)
            frmProgramLife.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSignUp_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void frmLoginPage_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        }

        private void frmLoginPage_AutoSizeChanged(object sender, EventArgs e)
        {
        }
    }
}
