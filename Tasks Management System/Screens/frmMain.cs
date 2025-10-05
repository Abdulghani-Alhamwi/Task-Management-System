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
using To_Do_List_Project.Screens;

namespace To_Do_List_Project
{
    public partial class frmMain : Form
    {
        public frmMain() => InitializeComponent(); 

        private void btnViewDailyTasks_Click(object sender, EventArgs e)
        {
            Form frmDailyTasks=new frmDailyToDoTasks();
            this.Hide();
            frmDailyTasks.Show();
        }

        private void btnAddNewDailyTasks_Click(object sender, EventArgs e)
        {
            Form frmDailyTasks = new frmDailyToDoTasks();
            this.Hide();
            frmDailyTasks.Show();
        }

        private void btnAddTimer_Click(object sender, EventArgs e)
        {
            Form frmSetTimer=new frmTimer();
            this.Hide();
            frmSetTimer.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLoginPage();
            this.Close();
            frmLogin.Show();

        }

        private void linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklabel.LinkVisited = true;

            Process.Start(new ProcessStartInfo("https://www.linkedin.com/in/abdulghani-al-hamwi-96a325317") { UseShellExecute = true });//we put UseShellExecute : to open the link in the default browser of the user
            //we can write : System.Diagnostics.Process.Start("https://www.linkedin.com/in/abdulghani-al-hamwi-96a325317");
        }

    }
}
