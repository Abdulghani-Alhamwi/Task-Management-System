using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Core;

namespace To_Do_List_Project
{
    public partial class frmNewTaskInfo : Form
    {
        public frmNewTaskInfo()
        {
            InitializeComponent();
        }

        private string _FileName = "Daily Tasks.txt";


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(clsTask.SaveDataToFile(txtTask,txtDeadLine,_FileName))
            MessageBox.Show("Task Added Successfully", "Process Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCancel_Click(sender,e);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form frmDailyTasks = new frmDailyToDoTasks();
            frmDailyTasks.Show();
            this.Close();
        }

    }
}
