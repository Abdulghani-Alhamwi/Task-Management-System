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

        Form frmLogin, frmProgramLife;

        bool CloseProgram = true;
        public frmSignUp(frmLoginPage frmLoginPage , Form frmFirst)
        {
            InitializeComponent();
            frmLogin = frmLoginPage;
            frmProgramLife = frmFirst;
            
          
        }

        private string _FileName = "Users.txt";

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            clsUser._AddUser(txtUserName,txtPassword,_FileName);
            MessageBox.Show("Added Successfully", "Successfully Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            frmLogin.Show();
            CloseProgram = false;
            this.Close();
        }

  
        Message _CurrentMessage;
        protected override void WndProc(ref Message m)
        {
            _CurrentMessage = m;
            /*
             * Window is a form or a certain control from the Operating system perspective .
             * wnp is the window procedure and it is a method to recieve and process the messages the are sent from windows to a specific window .
             */

            base.WndProc(ref m);
        }
        
        private void ValidateTextBox(object sender,CancelEventArgs e)
        {
            if (((TextBox)sender).Tag == txtPassword.Tag)
                txtUserName.CausesValidation = false;//txtUser name wont enter validation event function


            if (!(_CurrentMessage.Msg == 16)) // 16 is the window close message in decimal , when the window is requested to close -> it sends a message that is 16 in decimal .
                clsUtilControls.ValidateTextBox(sender, errorProvider1, e);
            else
            {
                CloseProgram = true;
                this.Close();
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin.ShowInTaskbar = true;
            CloseProgram = false;
            this.Hide();
            frmLogin.Show();
            this.Close();
       }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }


        private void frmSignUp_Load(object sender, EventArgs e)
        {
            btnExit.CausesValidation = false;// this tells winforms not to trigger validation when user clicked on btn_Exit
            lblLogin.CausesValidation = false;// this tells winforms not to trigger validation when user clicked on lbl_Login
        }

        private void frmSignUp_Shown(object sender, EventArgs e)
        {   
            txtUserName.Focus();
        }

        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(CloseProgram)
                frmProgramLife.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void frmSignUp_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width)/2,(Screen.PrimaryScreen.WorkingArea.Height - this.Height )/2);
        }

        private void pnlResponsiveControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            txtUserName.CausesValidation = true;//winforms will trigger validation for txtUserName -> txtUserName will enter validation event function when user tries to leave txtUserName for the validation process.
        }
    }
}
