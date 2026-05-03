using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using To_Do_List_Project.Screens;

namespace To_Do_List_Project
{
    public partial class frmMain : Form
    {
        Form frmProgramLife;
        internal bool CloseProgram = true;

        clsUser.stUserInfo CurrentUser = new clsUser.stUserInfo();
        //public frmMain(Form frmFirst, clsUser.stUserInfo CurrentUser = new clsUser.stUserInfo())
        public frmMain(Form frmFirst, clsUser.stUserInfo CurrentUser)
        {
            InitializeComponent();
            frmProgramLife = frmFirst;
            this.CurrentUser = CurrentUser;
        }
        private void btnViewDailyTasks_Click(object sender, EventArgs e)
        {
            Form frmDailyTasks=new frmDailyToDoTasks(this , frmProgramLife,CurrentUser);
            this.Hide();
            frmDailyTasks.Show();
        }

      
        private void btnAddTimer_Click(object sender, EventArgs e)
        {
            Form frmSetTimer=new frmTimer(frmProgramLife, CurrentUser);
            this.Hide();
            frmSetTimer.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLoginPage(frmProgramLife);
            CloseProgram = false;
            this.Close();
            frmLogin.Show();
        }

        private void linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklabel.LinkVisited = true;

            Process.Start(new ProcessStartInfo("https://www.linkedin.com/in/abdulghani-al-hamwi-96a325317") { UseShellExecute = true });//we put UseShellExecute : to open the link in the default browser of the user
            //we can write : System.Diagnostics.Process.Start("https://www.linkedin.com/in/abdulghani-al-hamwi-96a325317");
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(CloseProgram)
            frmProgramLife.Close();
        }

        private void frmMain_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
    }
}
